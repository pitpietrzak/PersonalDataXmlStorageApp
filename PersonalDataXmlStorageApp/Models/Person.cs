using DevExpress.XtraEditors.DXErrorProvider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace PersonalDataXmlStorageApp.Models
{
    public class Person : INotifyPropertyChanged, IDXDataErrorInfo
    {
        [XmlIgnore]
        private readonly Dictionary<string, bool> _errors = new Dictionary<string, bool>();

        public int Id { get; set; }

        private string _firstName;

        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }

        private string _lastName;
    
        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }

        private string _streetName;

        public string StreetName
        {
            get => _streetName;
            set
            {
                _streetName = value;
                OnPropertyChanged(nameof(StreetName));
            }
        }

        private string _houseNumber;

        public string HouseNumber
        {
            get => _houseNumber;
            set
            {
                _houseNumber = value;
                OnPropertyChanged(nameof(HouseNumber));
            }
        }

        private string _apartmentNumber;

        public string ApartmentNumber
        {
            get => _apartmentNumber;
            set
            {
                _apartmentNumber = value;
                OnPropertyChanged(nameof(ApartmentNumber));
            }
        }

        private string _postalCode;

        public string PostalCode
        {
            get => _postalCode;
            set
            {
                _postalCode = value;
                OnPropertyChanged(nameof(PostalCode));
            }
        }

        private string _town;

        public string Town
        {
            get => _town;
            set
            {
                _town = value;
                OnPropertyChanged(nameof(Town));
            }
        }

        private string _phoneNumber;

        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                _phoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        [XmlIgnore]
        private DateTime? _birthDate;

        public DateTime? BirthDate
        {
            get => _birthDate;
            set
            {
                _birthDate = value;
                OnPropertyChanged(nameof(BirthDate));
            }
        }

        public int? Age
        {
            get
            {
                if (!BirthDate.HasValue) return null;
                var now = DateTime.Today;
                var age = now.Year - BirthDate.Value.Year;
                if (now < BirthDate.Value.AddYears(age)) age--;
                return age;

            }
        }
        
        public string DateOfBirth
        {
            get => BirthDate != null ? BirthDate.Value.ToShortDateString() : string.Empty;
            set => BirthDate = DateTime.Parse(value);
        }

        [XmlIgnore]
        public bool IsNew { get; set; }

        [XmlIgnore]
        public bool IsDirty { get; set; }

        [XmlIgnore]
        public bool HasErrors { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void GetPropertyError(string propertyName, ErrorInfo info)
        {
            switch (propertyName)
            {
                case "Age":
                case "ApartmentNumber":
                    return;
                case "FirstName" when string.IsNullOrEmpty(FirstName):
                    info.ErrorText = @"Enter first name";
                    break;
                case "LastName" when string.IsNullOrEmpty(LastName):
                    info.ErrorText = @"Enter last name";
                    break;
                case "StreetName" when string.IsNullOrEmpty(StreetName):
                    info.ErrorText = @"Enter street name";
                    break;
                case "HouseNumber" when string.IsNullOrEmpty(HouseNumber):
                    info.ErrorText = @"Enter house number";
                    break;
                case "PostalCode" when string.IsNullOrEmpty(PostalCode):
                    info.ErrorText = @"Enter postal code";
                    break;
                case "PostalCode" when !string.IsNullOrEmpty(PostalCode) && !Regex.Match(PostalCode, @"^\d{2}(?:[-\s]\d{3})?$").Success:
                    info.ErrorText = @"Postal code format should be: NN-NNN";
                    break;
                case "Town" when string.IsNullOrEmpty(Town):
                    info.ErrorText = @"Enter town";
                    break;
                case "PhoneNumber" when string.IsNullOrEmpty(PhoneNumber):
                    info.ErrorText = @"Enter phone number";
                    break;
                case "BirthDate" when !BirthDate.HasValue:
                    info.ErrorText = @"Enter birth date";
                    break;
            }

            if (!string.IsNullOrEmpty(info.ErrorText))
            {
                if (!_errors.ContainsKey(propertyName))
                {
                    _errors.Add(propertyName,true);
                }
            }
            else
            {
                if (_errors.ContainsKey(propertyName))
                {
                    _errors.Remove(propertyName);
                }
            }

            HasErrors = _errors.Values.Count > 0;
        }

        public void GetError(ErrorInfo info)
        {}

        protected virtual void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(propertyName, true);
        }

        protected virtual void OnPropertyChanged(string propertyName, bool makeDirty)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            if (makeDirty)
                IsDirty = true;
        }
    }
}
