using System;

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

        public DateTime? ExpiryDateFrom { get; set; }

        public DateTime? ExpiryDateTo { get; set; }

        public void Edit(Personel p)
        {
            FirstName = p.FirstName;
            LastName = p.LastName;
            Role = p.Role;
            Password = p.Password;
        }
    }

    partial class Client
    {
        public string DisplayName
        {
            get
            {
                return string.IsNullOrEmpty(Name) ? $"{FirstName} {LastName}" : Name;
            }
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

    partial class Object
    {
        public string DisplayName
        {
            get
            {
                return $"{Client.DisplayName} - {Type}";
            }
        }
    }
    public enum StatusEnum
    {
        OPN,
        PRO,
        CAN,
        FIN
    }

    partial class Request
    {
        public DateTime? CreateDateFrom { get; set; }

        public DateTime? CreateDateTo { get; set; }

        public DateTime? EndDateFrom { get; set; }

        public DateTime? EndDateTo { get; set; }
    }

    partial class Activity
    {
        public DateTime? CreateDateFrom { get; set; }

        public DateTime? CreateDateTo { get; set; }

        public DateTime? EndDateFrom { get; set; }

        public DateTime? EndDateTo { get; set; }
    }
}