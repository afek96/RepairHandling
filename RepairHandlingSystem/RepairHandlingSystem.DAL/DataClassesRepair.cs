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

        public override string ToString()
        {
            return DisplayName;
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

        public override string ToString()
        {
            return DisplayName;
        }
    }

    partial class Role
    {
        
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

        public override string ToString()
        {
            return DisplayName;
        }
    }

    partial class Request
    {
        public DateTime? CreateDateFrom { get; set; }

        public DateTime? CreateDateTo { get; set; }

        public DateTime? EndDateFrom { get; set; }

        public DateTime? EndDateTo { get; set; }

        public override string ToString()
        {
            return Object.ToString();
        }
    }

    partial class Activity
    {
        public DateTime? CreateDateFrom { get; set; }

        public DateTime? CreateDateTo { get; set; }

        public DateTime? EndDateFrom { get; set; }

        public DateTime? EndDateTo { get; set; }

        public override string ToString()
        {
            return $"{Request} - {Type}";
        }
    }
}