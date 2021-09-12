using ManagerLibrary.Models;
using System.Collections.Generic;

namespace ManagerLibrary.DataAccess
{
    public interface IDataConnection
    {
        void CreateWord(WordModel mdl);
        void CreateTag(TagModel mdl);
        void CreateRecord(RecordModel mdl);
        List<WordModel> GetAllWordSpellings();
        List<TagModel> GetAllTags();
        List<MetricModel> GetAllMetrics();
        List<MetricModel> GetMetircByTagId(int tagId);
        WordModel GetWordById(int id);
        void UpdateWordById(WordModel mdl);
        void UpdateTagById(TagModel mdl);
        void DeleteWordById(int id);
        void DeleteTagById(int id);
        List<WordModel> GetTaggedWordSpellings(int tagID);
        List<WordModel> GetRemovedWordSpellings();
        void RemoveWordById(int wordId);
        void RecoverWordById(int wordId);
    }
}
