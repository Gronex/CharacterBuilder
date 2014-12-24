using System;

namespace CharacterBuilder.Model
{
    public class DataService : IDataService
    {
        public void GetData(Action<DataItem, Exception> callback)
        {
            // Use this to connect to the actual data service

            var item = new DataItem("Character Builder");
            callback(item, null);
        }
    }
}