using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairHandlingSystem.Common
{
    public enum FormModeEnum
    {
        Create,
        Edit,
        View
    }

    public enum RoleEnum
    {
        ADM,
        MAN,
        WOR
    }

    public enum StatusEnum
    {
        OPN,
        PRO,
        CAN,
        FIN
    }
}
