using Shared.DataTransferObjects;

namespace Service.Contracts;

public interface IEmployeeService
{
    IEnumerable<EmployeeDto> GetEmployees(Guid companyId,
        bool trackChanges);

    EmployeeDto GetEmployee(Guid companyId,
        Guid employeeId,
        bool trackChanges);

    EmployeeDto CreateEmployeeForCompany(Guid companyId,
        EmployeeForCreationDto employee,
        bool trackChanges);

    void DeleteEmployeeForCompany(Guid companyId,
        Guid id,
        bool trackChanges);

    void UpdateEmployeeForCompany(Guid companyId,
        Guid id,
        EmployeeForUpdateDto employee,
        bool compTrackChanges,
        bool empTrackChanges);
}