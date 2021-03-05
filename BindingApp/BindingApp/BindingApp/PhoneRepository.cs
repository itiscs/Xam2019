using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BindingApp
{
    public class PhoneRepository
    {
        SQLiteAsyncConnection database;
        public PhoneRepository(string databasePath)
        {
            database = new SQLiteAsyncConnection(databasePath);
            database.CreateTableAsync<Phone>();
        }
        public async Task<IEnumerable<Phone>> GetItemsAsync()
        {
            return await database.Table<Phone>().ToListAsync();
        }
        public async Task<Phone> GetItemAsync(int id)
        {
            return await database.GetAsync<Phone>(id);
        }
        public async Task<int> DeleteItemAsync(int id)
        {
            return await database.DeleteAsync<Phone>(id);
        }
        public async Task<int> SaveItemAsync(Phone item)
        {
            if (item.Id != 0)
            {
                await database.UpdateAsync(item);
                return item.Id;
            }
            else
            {
                return await database.InsertAsync(item);
            }
        }
    }
    
}
