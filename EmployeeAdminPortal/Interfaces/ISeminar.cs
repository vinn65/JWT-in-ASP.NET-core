using EmployeeAdminPortal.Services;

namespace EmployeeAdminPortal.Interfaces
{
    public interface ISeminar
    {
        Task<dynamic> PostData(SeminarData seminar);
    }
}