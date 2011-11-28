using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PROJETO_FINAL_LC
{
    public class Session
    {
        private int code = 0;
        private String userLogin = "";
        private Video video;
        private String date;
        private float evaluetion;
        private String mode;
        private String comment;

        public Session(String userLogin, Video video, DateTime date, 
                       float evaluetion, String mode, String comment)
        {
            this.userLogin = userLogin;
            this.video = video;
            if (date != null)
                this.date = date.Year + "-" + date.Month + "-" + date.Day;
            else
                this.date = null;
            this.evaluetion = evaluetion;
            this.mode = mode;
            this.comment = comment;
        }

        public Session(String userLogin, Video video, String date,
                       float evaluetion, String mode, String comment)
        {
            this.userLogin = userLogin;
            this.video = video;
            this.date = date;
            this.evaluetion = evaluetion;
            this.mode = mode;
            this.comment = comment;
        }

        public void setCode(int code)
        {
            this.code = code;
        }

        public String getUserLogin()
        {
            return userLogin;
        }

        public int getVideoCode()
        {
            if (video != null)
                return video.getCode();
            else
                return -1;
        }

        public Video getVideo()
        {
            return this.video;
        }

        public String getDate()
        {
            return this.date;
        }

        public String getMode()
        {
            return mode;
        }

        public float getEvaluetion()
        {
            return this.evaluetion;
        }

        public String getComment()
        {
            return this.comment;
        }
    }
}
