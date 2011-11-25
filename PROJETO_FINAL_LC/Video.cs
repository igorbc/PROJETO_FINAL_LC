using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PROJETO_FINAL_LC
{
    public class Video
    {
        private int code = 0;
        private String originalTitle;
        private String nationalTitle;
        private String director;
        private int year;
        private int duration;
        private String category;
        private String[] tags;

        public Video(String originalTitle, String nationalTitle, String director,
                    int year, int duration, String category, String[] tags)
        {
            this.originalTitle = originalTitle;
            this.nationalTitle = nationalTitle;
            this.director = director;
            this.year = year;
            this.duration = duration;
            this.category = category;
            this.tags = tags;
        }

        public Video(int code, String originalTitle, String nationalTitle, String director,
                    int year, int duration, String category, String[] tags)
                    : this(originalTitle, nationalTitle, director, year, duration, category, tags)
        {
            this.code = code;
        }

        public String getOriginalTitle()
        {
            return originalTitle;
        }

        public String getNationalTitle()
        {
            return nationalTitle;
        }

        public String getDirector()
        {
            return director;
        }

        public int getYear()
        {
            return year;
        }

        public int getDuration()
        {
            return duration;
        }

        public String getCategory()
        {
            return category;
        }

        public String[] getTags()
        {
            return tags;
        }

        public int getCode()
        {
            return code;
        }

        public void setCode(int code)
        {
            this.code = code;
        }
    }
}
