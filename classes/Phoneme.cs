using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishHelperApp.classes
{
    internal class Phoneme
    {
        private string FileLocation { get; set; }
        private string PhoneticSymbol { get; set; }
        private string TongueHeight { get; set; }
        private string TonguePart { get; set; }
        private string LipPosition { get; set; }
        private string Length { get; set; }

        public Phoneme() { }

        public Phoneme(string fileLocation, string phoneticSymbol, string tongueHeight, string tonguePart, string lipPosition, string length)
        {
            FileLocation = fileLocation;
            PhoneticSymbol = phoneticSymbol;
            TongueHeight = tongueHeight;
            TonguePart = tonguePart;
            LipPosition = lipPosition;
            Length = length;
        }

        public void SetFileLocation(string fileLocation)
        {
            FileLocation = fileLocation;
        }

        public string GetFileLocation()
        {
            return FileLocation;
        }

        public void SetPhoneticSymbol(string phoneticSymbol)
        {
            PhoneticSymbol = phoneticSymbol;
        }

        public string GetPhoneticSymbol()
        {
            return PhoneticSymbol;
        }

        public void SetTongueHeight(string tongueHeight)
        {
            TongueHeight = tongueHeight;
        }

        public string GetTongueHieght()
        {
            return TongueHeight;
        }

        public void SetTonguePart(string tonguePart)
        {
            TonguePart = tonguePart;
        }

        public string GetTonguePart()
        {
            return TonguePart;
        }

        public void SetLipPosition(string lipPosition)
        {
            LipPosition = lipPosition;
        }

        public string GetLipPosition()
        {
            return LipPosition;
        }

        public void SetLength(string length)
        {
            Length = length;
        }

        public string GetLength()
        {
            return Length;
        }

        public string[] GetValues()
        {
            string[] values = { PhoneticSymbol, TongueHeight, TonguePart, LipPosition, Length };
            return values;
        }

    }
}
