using ManagerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;

namespace ManagerLibrary.DataAccess
{
    class SqliteConnector : IDataConnection
    {
        string CS = GlobalConfig.ConnectionString("SQLite");

        public void CreateRecord(RecordModel mdl)
        {
            using (SQLiteConnection con = new SQLiteConnection(CS))
            {
                SQLiteCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO record (word_id, generated_time, test_result) " +
                    "VALUES (@word_id, @datetime, @test_res)";
                cmd.Parameters.AddWithValue("@word_id", mdl.WordID);
                cmd.Parameters.AddWithValue("@datetime", mdl.RecTime);
                cmd.Parameters.AddWithValue("@test_res", mdl.RecState ? 1 : 0);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void CreateTag(TagModel mdl)
        {
            using (SQLiteConnection con = new SQLiteConnection(CS))
            {
                SQLiteCommand cmd = con.CreateCommand();
                cmd.CommandText = @"INSERT INTO tag (tag_name, info) VALUES (@name, @info)";
                cmd.Parameters.AddWithValue("@name", mdl.TagName);
                cmd.Parameters.AddWithValue("@info", mdl.TagInfo);

                con.Open();
                cmd.ExecuteNonQuery();

                mdl.TagID = GetLastInsertId(con);
            }
        }

        private int GetLastInsertId(SQLiteConnection con)
        {
            SQLiteCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT LAST_INSERT_ROWID()";
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public void CreateWord(WordModel mdl)
        {
            using (SQLiteConnection con = new SQLiteConnection(CS))
            {
                // Prepare the SQL command.   
                SQLiteCommand cmd = con.CreateCommand();
                cmd.CommandText = @"INSERT INTO word " +
                    "(spelling, word_definition, context, context_source, note, removed, occurrence_time) " +
                    "VALUES (@spelling, @word_definition, @context, @context_source, @note, 0, 1)";
                cmd.Parameters.AddWithValue("@spelling", mdl.WordText);
                cmd.Parameters.AddWithValue("@word_definition", mdl.Definition);
                cmd.Parameters.AddWithValue("@context", mdl.Context);
                cmd.Parameters.AddWithValue("@context_source", mdl.ContextSource);
                cmd.Parameters.AddWithValue("@note", mdl.Note);

                // Shoot the transaction.
                con.Open();
                SQLiteTransaction sqlTran = con.BeginTransaction();
                try
                {
                    cmd.Transaction = sqlTran;
                    cmd.ExecuteNonQuery();

                    mdl.WordID = GetLastInsertId(con);
                    foreach (TagModel tag in mdl.Tags)
                    {
                        CreateTagging(mdl.WordID, tag.TagID, con);
                    }

                    sqlTran.Commit();
                }
                catch (Exception ex)
                {
                    sqlTran.Rollback();
                    Debug.WriteLine($"rollback: {ex.ToString()}");
                }
            }
        }

        private void CreateTagging(int wordId, int tagId, SQLiteConnection con)
        {
            SQLiteCommand cmd = con.CreateCommand();
            cmd.CommandText = @"INSERT INTO tagging (tag_id, word_id) VALUES (@tag_id, @word_id)";
            cmd.Parameters.AddWithValue("@tag_id", tagId);
            cmd.Parameters.AddWithValue("@word_id", wordId);

            cmd.ExecuteNonQuery();
        }

        public void DeleteTagById(int id)
        {
            using (SQLiteConnection con = new SQLiteConnection(CS))
            {
                SQLiteCommand cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM tag WHERE id = @tag_id";
                cmd.Parameters.AddWithValue("@tag_id", id);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteWordById(int id)
        {
            using (SQLiteConnection con = new SQLiteConnection(CS))
            {
                SQLiteCommand cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM word WHERE id = @word_id";
                cmd.Parameters.AddWithValue("@word_id", id);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<MetricModel> GetAllMetrics()
        {
            List<MetricModel> metrics = new List<MetricModel>();
            using (SQLiteConnection con = new SQLiteConnection(CS))
            {
                SQLiteCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM metric";

                con.Open();
                using (SQLiteDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        metrics.Add(new MetricModel(
                            Convert.ToInt32(rdr["word_id"]),
                            (double)rdr["overall_accuracy"],
                            (double)rdr["current_accuracy"]));
                    }
                }
            }
            return metrics;
        }

        public List<TagModel> GetAllTags()
        {
            List<TagModel> tags = new List<TagModel>();
            using (SQLiteConnection con = new SQLiteConnection(CS))
            {
                SQLiteCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM tag";

                con.Open();
                using (SQLiteDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        tags.Add(new TagModel(
                            rdr.GetInt32(0),
                            (string)rdr["tag_name"],
                            (string)rdr["info"]));
                    }
                }
            }

            return tags;
        }

        public List<WordModel> GetAllWordSpellings()
        {
            List<WordModel> words = new List<WordModel>();
            using (SQLiteConnection con = new SQLiteConnection(CS))
            {
                SQLiteCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT id, spelling FROM available_word";

                con.Open();
                using (SQLiteDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        words.Add(
                            new WordModel()
                            {
                                WordID = Convert.ToInt32(rdr["id"]),
                                WordText = (string)rdr["spelling"]
                            });
                    }
                }
            }
            return words;
        }

        public List<MetricModel> GetMetircByTagId(int tagId)
        {
            List<MetricModel> metrics = new List<MetricModel>();
            using (SQLiteConnection con = new SQLiteConnection(CS))
            {
                SQLiteCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT metric.* FROM metric " +
                    "INNER JOIN tagging " +
                    "ON tagging.tag_id = @tag_id " +
                    "AND tagging.word_id = metric.word_id";
                cmd.Parameters.AddWithValue("@tag_id", tagId);

                con.Open();
                using (SQLiteDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        metrics.Add(new MetricModel(
                            Convert.ToInt32(rdr["word_id"]),
                            (double)rdr["overall_accuracy"],
                            (double)rdr["current_accuracy"]));
                    }
                }
            }
            return metrics;
        }

        public List<WordModel> GetRemovedWordSpellings()
        {
            List<WordModel> words = new List<WordModel>();
            using (SQLiteConnection con = new SQLiteConnection(CS))
            {
                SQLiteCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT id, spelling FROM word WHERE removed = 1";

                con.Open();
                using (SQLiteDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        words.Add(
                            new WordModel()
                            {
                                WordID = Convert.ToInt32(rdr["id"]),
                                WordText = (string)rdr["spelling"]
                            });
                    }
                }
            }
            return words;
        }

        public List<WordModel> GetTaggedWordSpellings(int tagId)
        {
            List<WordModel> taggedWords = new List<WordModel>();

            using (SQLiteConnection con = new SQLiteConnection(CS))
            {
                SQLiteCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT word_id, spelling FROM available_word " +
                    "INNER JOIN tagging " +
                    "ON tagging.tag_id = @tag_id " +
                    "AND available_word.id = tagging.word_id";
                cmd.Parameters.AddWithValue("@tag_id", tagId);

                con.Open();
                using (SQLiteDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        taggedWords.Add(new WordModel()
                        {
                            WordID = Convert.ToInt32(rdr["word_id"]),
                            WordText = (string)rdr["spelling"]
                        });
                    }
                }
            }

            return taggedWords;
        }

        public WordModel GetWordById(int wordId)
        {
            WordModel mdl = new WordModel() { WordID = wordId };

            using (SQLiteConnection con = new SQLiteConnection(CS))
            {
                SQLiteCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM word WHERE id = @word_id";
                cmd.Parameters.AddWithValue("@word_id", wordId);

                con.Open();
                using (SQLiteDataReader rdr = cmd.ExecuteReader())
                {
                    if (rdr.Read())
                    {
                        mdl.WordText = (string)rdr["spelling"];
                        mdl.Definition = (string)rdr["word_definition"];
                        mdl.Context = (string)rdr["context"];
                        mdl.ContextSource = (string)rdr["context_source"];
                        mdl.Note = (string)rdr["note"];

                        SQLiteCommand cmdTagging = con.CreateCommand();
                        cmdTagging.CommandText = "SELECT tag.id AS id, tag_name, tag.info FROM tagging " +
                            "INNER JOIN tag ON tagging.tag_id = tag.id AND tagging.word_id = @word_id";
                        cmdTagging.Parameters.AddWithValue("@word_id", wordId);
                        using (SQLiteDataReader rdrTagging = cmdTagging.ExecuteReader())
                        {
                            while (rdrTagging.Read())
                            {
                                mdl.Tags.Add(new TagModel(
                                    Convert.ToInt32(rdrTagging["id"]),
                                    (string)rdrTagging["tag_name"],
                                    (string)rdrTagging["info"]));
                            }
                        }
                    }
                    else
                    {
                        mdl = null;
                    }
                }
            }

            return mdl;
        }

        public void RecoverWordById(int wordId)
        {
            using (SQLiteConnection con = new SQLiteConnection(CS))
            {
                SQLiteCommand cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE word SET removed = 0 WHERE id = @word_id";
                cmd.Parameters.AddWithValue("@word_id", wordId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void RemoveWordById(int wordId)
        {
            using (SQLiteConnection con = new SQLiteConnection(CS))
            {
                SQLiteCommand cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE word SET removed = 1 WHERE id = @word_id";
                cmd.Parameters.AddWithValue("@word_id", wordId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateTagById(TagModel mdl)
        {
            using (SQLiteConnection con = new SQLiteConnection(CS))
            {
                SQLiteCommand cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE tag " +
                    "SET tag_name = @tag_name, info = @info " +
                    "WHERE id = @tag_id";
                cmd.Parameters.AddWithValue("@tag_id", mdl.TagID);
                cmd.Parameters.AddWithValue("@tag_name", mdl.TagName);
                cmd.Parameters.AddWithValue("@info", mdl.TagInfo);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateWordById(WordModel mdl)
        {
            using (SQLiteConnection con = new SQLiteConnection(CS))
            {
                // Update basic info.
                SQLiteCommand cmd = con.CreateCommand();
                cmd.CommandText =
                    "UPDATE word SET spelling = @spelling, " +
                    "word_definition = @word_definition, " +
                    "context = @context, context_source = @context_source, " +
                    "note = @note WHERE id = @word_id";
                cmd.Parameters.AddWithValue("@word_id", mdl.WordID);
                cmd.Parameters.AddWithValue("@spelling", mdl.WordText);
                cmd.Parameters.AddWithValue("@word_definition", mdl.Definition);
                cmd.Parameters.AddWithValue("@context", mdl.Context);
                cmd.Parameters.AddWithValue("@context_source", mdl.ContextSource);
                cmd.Parameters.AddWithValue("@note", mdl.Note);

                con.Open();
                cmd.ExecuteNonQuery();

                // Update tags: Clear the old tags first and readd all the updated tags.
                cmd.CommandText = "DELETE FROM tagging WHERE word_id = @word_id";
                cmd.ExecuteNonQuery();
                foreach (TagModel tag in mdl.Tags)
                {
                    CreateTagging(mdl.WordID, tag.TagID, con);
                }
            }
        }
    }
}
