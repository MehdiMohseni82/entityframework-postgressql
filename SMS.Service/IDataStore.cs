namespace SMS.Service
{
    public interface IDataStore
    {
        void CommitChanges();

        IRepositories.ICoursRepository CoursRepository { get; }

        IRepositories.IStudentRepository StudentRepository { get; }

        IRepositories.IStudentTypeRepository StudentTypeRepository { get; }
    }
}