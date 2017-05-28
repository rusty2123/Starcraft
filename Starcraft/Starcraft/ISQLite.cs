using System;
using SQLite.Net;

namespace Starcraft
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
