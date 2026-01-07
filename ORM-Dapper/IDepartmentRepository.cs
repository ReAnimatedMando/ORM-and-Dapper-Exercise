namespace ORM_Dapper;

public interface IDepartmentRepository
{
    IEnumerable<Department> GetAllDepartments();

    public void InsertDepartment()
    {
        
    }
}