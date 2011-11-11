using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PROJETO_FINAL_LC
{
    public class User
    {
        private String login;
        private String password;
        private String name;
        private EvaluetionMethodInfo evaluetionMethodInfo;

        public User(String login, String password, String name)
        {
            this.login = login;
            this.password = password;
            this.name = name;
        }

        public String getLogin()
        {
            return login;
        }

        public String getName()
        {
            return name;
        }

        public String getPassword()
        {
            return password;
        }

        public EvaluetionMethodInfo getEvaluetionMethodInfo()
        {
            return evaluetionMethodInfo;
        }

        public void setEvaluetionMethodInfo(EvaluetionMethod evaluetionMethod,
                                            float lowerLimit, float higherLimit, float step)
        {
            evaluetionMethodInfo = new EvaluetionMethodInfo(evaluetionMethod, lowerLimit,
                                                            higherLimit, step);
        }

    }
}
