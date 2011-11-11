using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PROJETO_FINAL_LC
{
    class Session
    {
        private Video video;
        private float evaluetion;
        private String mode;
        private String comment;

        public Session(Video video, float evaluetion, String mode, String comment)
        {
            this.video = video;
            this.evaluetion = evaluetion;
            this.mode = mode;
            this.comment = comment;
        }
    }
}
