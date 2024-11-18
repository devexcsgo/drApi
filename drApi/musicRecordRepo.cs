namespace drApi
{
    public class musicRecordRepo
    {
        private int _nextId;
        private readonly List<musicRecord> _musicRecords;
        public musicRecordRepo()
        {
            _musicRecords = new List<musicRecord>()
            {
                new musicRecord { Id = 1, Title = "The Dark Side of the Moon", Artist = "Pink Floyd", Duration = 43, PublicationYear = 1973 },
                new musicRecord { Id = 2, Title = "The Wall", Artist = "Pink Floyd", Duration = 81, PublicationYear = 1979 },
                new musicRecord { Id = 3, Title = "Wish You Were Here", Artist = "Pink Floyd", Duration = 44, PublicationYear = 1975 }
            };
        }
        public IEnumerable<musicRecord> GetAll()
        {
            IEnumerable<musicRecord> getAllList = new List<musicRecord>(_musicRecords);

            return getAllList;
        }
    }
}
