using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PROJETO_FINAL_LC
{
    class DaoSession : DbAssistent
    {

        public Boolean createTable()
        {
            return createTable(null, null);
        }

        public Boolean createTable(Type type, String errorMethod)
        {
            String createModeTableString = "CREATE TABLE IF NOT EXISTS MODE (" +
            "code INTEGER PRIMARY KEY AUTO_INCREMENT, " +
            "name VARCHAR(30))";

            String createSessionTableString = "CREATE TABLE IF NOT EXISTS SESSION (" +
            "code INTEGER PRIMARY KEY AUTO_INCREMENT, " +
            "date DATE NOT NULL, " +
            "videoCode INTEGER NOT NULL, " +
            "evaluetion VARCHAR(7), " +
            "modeCode INTEGER, " +
            "comment VARCHAR(2048), " +
            "FOREIGN KEY (videoCode) references VIDEO(code), " +
            "FOREIGN KEY (modeCode) references MODE(code))";

            return
            executeNonQuery(createModeTableString, type, errorMethod, "Create MODE table failed.") &&
            executeNonQuery(createSessionTableString, type, errorMethod, "Create SESSION table failed.");
        }

    }
}
