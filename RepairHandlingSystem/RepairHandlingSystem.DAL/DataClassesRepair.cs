namespace RepairHandlingSystem.DAL
{
    partial class DataClassesRepairDataContext
    {
    }

    partial class Personel
    {
        public string DisplayName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public void Edit(Personel p)
        {
            FirstName = p.FirstName;
            LastName = p.LastName;
            Role = p.Role;
            Password = p.Password;
        }
    }

    partial class Role
    {
        public enum RoleEnum
        {
            ADM,
            MAN,
            WOR
        }
    }
}