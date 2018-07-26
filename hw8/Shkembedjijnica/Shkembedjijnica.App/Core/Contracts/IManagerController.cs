
using Shkembedjijnica.App.Core.DTOs;

namespace Shkembedjijnica.App.Core.Contracts
{
    public interface IManagerController
    {
        void AddManager(int employeeId, int managerId);

        ManagerDto GetManagerInfo(int employeeId);
    }
}
