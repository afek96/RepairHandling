using RepairHandlingSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Object = RepairHandlingSystem.DAL.Object;

namespace RepairHandlingSystem.Managers
{
    public class RequestManager
    {
        public RequestManager()
        {

        }

        public void AddRequest(Request request)
        {
            using (DataClassesRepairDataContext dc = new DataClassesRepairDataContext())
            {
                request.CreateDate = DateTime.Now;
                dc.Requests.InsertOnSubmit(request);
                dc.SubmitChanges();
            }
        }

        public void EditRequest(Request request)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Request> GetRequests(Request searchCriteria)
        {
            DataClassesRepairDataContext dc = new DataClassesRepairDataContext();
            if (searchCriteria == null)
                return dc.Requests;

            return dc.Requests.Where(r =>
                (searchCriteria.IdRequest == 0 || r.IdRequest == searchCriteria.IdRequest) &&
                (searchCriteria.IdPersonel == 0 || r.IdPersonel == searchCriteria.IdPersonel) &&
                (searchCriteria.IdObject == 0 || r.IdObject == searchCriteria.IdObject) &&
                (string.IsNullOrEmpty(searchCriteria.Description) || r.Description.Contains(searchCriteria.Description)) &&
                (string.IsNullOrEmpty(searchCriteria.Result) || r.Result.Contains(searchCriteria.Result)) &&
                (string.IsNullOrEmpty(searchCriteria.Status) || r.Status.Equals(searchCriteria.Status)) &&
                (!searchCriteria.CreateDateFrom.HasValue || (r.CreateDate > searchCriteria.CreateDateFrom && r.CreateDate < searchCriteria.CreateDateTo)) &&
                (!searchCriteria.EndDateFrom.HasValue || (r.EndDate.HasValue && r.EndDate > searchCriteria.EndDateFrom && r.EndDate < searchCriteria.EndDateTo)));
        }

        public void AddActivity(Activity activity)
        {
            using (DataClassesRepairDataContext dc = new DataClassesRepairDataContext())
            {
                activity.CreateDate = DateTime.Now;
                dc.Activities.InsertOnSubmit(activity);
                dc.SubmitChanges();
            }
        }

        public void EditActivity(Activity activity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Activity> GetActivities(Activity searchCriteria)
        {
            DataClassesRepairDataContext dc = new DataClassesRepairDataContext();
            if (searchCriteria == null)
                return dc.Activities;

            return dc.Activities.Where(a =>
                (searchCriteria.IdActivity == 0 || a.IdActivity == searchCriteria.IdActivity) &&
                (searchCriteria.IdRequest == 0 || searchCriteria.IdRequest == null || a.IdRequest == searchCriteria.IdRequest) &&
                (searchCriteria.IdPersonel == null || a.IdPersonel == searchCriteria.IdPersonel) &&
                (string.IsNullOrEmpty(searchCriteria.Description) || a.Description.Contains(searchCriteria.Description)) &&
                (string.IsNullOrEmpty(searchCriteria.Result) || a.Result.Contains(searchCriteria.Result)) &&
                (string.IsNullOrEmpty(searchCriteria.Status) || a.Status.Equals(searchCriteria.Status)) &&
                (string.IsNullOrEmpty(searchCriteria.Type) || a.Type.StartsWith(searchCriteria.Type)));
        }

        public void AddClient(Client client)
        {
            using (DataClassesRepairDataContext dc = new DataClassesRepairDataContext())
            {
                dc.Clients.InsertOnSubmit(client);
                dc.SubmitChanges();
            }
        }

        public IQueryable<Client> GetClients(Client searchCriteria)
        {
            DataClassesRepairDataContext dc = new DataClassesRepairDataContext();
            if (searchCriteria == null)
                return dc.Clients;

            return dc.Clients.Where(c =>
                (searchCriteria.IdClient == 0 || c.IdClient == searchCriteria.IdClient) &&
                (searchCriteria.IdAddress == 0 || c.IdAddress == searchCriteria.IdAddress) &&
                (string.IsNullOrEmpty(searchCriteria.Name) || c.Name.StartsWith(searchCriteria.Name)) &&
                (string.IsNullOrEmpty(searchCriteria.FirstName) || c.FirstName.StartsWith(searchCriteria.FirstName)) &&
                (string.IsNullOrEmpty(searchCriteria.LastName) || c.LastName.StartsWith(searchCriteria.LastName)) &&
                (string.IsNullOrEmpty(searchCriteria.PhoneNumber) || c.PhoneNumber.StartsWith(searchCriteria.PhoneNumber)));
        }

        public void AddObjectType(ObjectType objectType)
        {
            using (DataClassesRepairDataContext dc = new DataClassesRepairDataContext())
            {
                dc.ObjectTypes.InsertOnSubmit(objectType);
                dc.SubmitChanges();
            }
        }

        public IQueryable<ObjectType> GetObjectTypes(ObjectType searchCriteria)
        {
            DataClassesRepairDataContext dc = new DataClassesRepairDataContext();
            if (searchCriteria == null)
                return dc.ObjectTypes;

            return dc.ObjectTypes.Where(o =>
                (string.IsNullOrEmpty(searchCriteria.ObjType) || o.ObjType.StartsWith(searchCriteria.ObjType)) &&
                (string.IsNullOrEmpty(searchCriteria.Name) || o.Name.StartsWith(searchCriteria.Name)));
        }

        public void AddObject(Client client, ObjectType objectType, string name = null)
        {
            using (DataClassesRepairDataContext dc = new DataClassesRepairDataContext())
            {
                Object @object = new Object()
                {
                    IdClient = client.IdClient,
                    Type = objectType.ObjType,
                    Name = name
                };

                dc.Objects.InsertOnSubmit(@object);
                dc.SubmitChanges();
            }
        }

        public void AddObject(Object @object)
        {
            using (DataClassesRepairDataContext dc = new DataClassesRepairDataContext())
            {
                dc.Objects.InsertOnSubmit(@object);
                dc.SubmitChanges();
            }
        }

        public IQueryable<Object> GetObjects(Object searchCriteria)
        {
            DataClassesRepairDataContext dc = new DataClassesRepairDataContext();
            if (searchCriteria == null)
                return dc.Objects;

            return dc.Objects.Where(o =>
                (searchCriteria.IdObject == 0 || o.IdObject == searchCriteria.IdObject) &&
                (searchCriteria.IdClient == 0 || o.IdClient == searchCriteria.IdClient) &&
                (string.IsNullOrEmpty(searchCriteria.Name) || o.Name.StartsWith(searchCriteria.Name)) &&
                (string.IsNullOrEmpty(searchCriteria.Type) || o.Type.StartsWith(searchCriteria.Type)));
        }

        public IQueryable<ActivityType> GetActivityTypes(ActivityType searchCriteria)
        {
            DataClassesRepairDataContext dc = new DataClassesRepairDataContext();
            if (searchCriteria == null)
                return dc.ActivityTypes;

            return dc.ActivityTypes.Where(a =>
                (string.IsNullOrEmpty(searchCriteria.ActType) || a.ActType.StartsWith(searchCriteria.ActType)) &&
                (string.IsNullOrEmpty(searchCriteria.Name) || a.Name.Contains(searchCriteria.Name)));
        }
    }
}
