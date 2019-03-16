using RepairHandlingSystem.Common;
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
            ExpiryDate = p.ExpiryDate;
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

        public void Edit(Request request)
        {
            Description = request.Description;
            Result = request.Result;
            Status = request.Status;
            IdObject = request.IdObject;
            if ((Status == StatusEnum.FIN.ToString() || Status == StatusEnum.CAN.ToString()) && EndDate == null)
                EndDate = DateTime.Now;
        }

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

        public void Edit(Activity activity)
        {
            SequenceNo = activity.SequenceNo;
            Description = activity.Description;
            Result = activity.Result;
            Status = activity.Status;
            
            if ((Status == StatusEnum.FIN.ToString() || Status == StatusEnum.CAN.ToString()) && EndDate == null)
                EndDate = DateTime.Now;

            Type = activity.Type;
            IdPersonel = activity.IdPersonel;
        }
    }

    partial class ActivityType
    {
        public override string ToString()
        {
            return ActType;
        }
    }
}