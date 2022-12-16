namespace DesignPatterns.Strategy
{
    public class FileController
    {
        private readonly IFileStorage _fileStorage;

        public FileController(IFileStorage fileStorage) =>
            _fileStorage = fileStorage;
    }

    public interface IFileStorage
    {
        byte[] GetFile(string id);

        void Save();
    }

    public class LocalStorage : IFileStorage
    {
        public byte[] GetFile(string id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class S3 : IFileStorage
    {
        public byte[] GetFile(string id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
