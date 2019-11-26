using DevExpress.XtraEditors.DXErrorProvider;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace PersonalDataXmlStorageApp.Models
{
    public class Person : INotifyPropertyChanged, IDXDataErrorInfo
    {
        [XmlIgnore]
        private Dictionary<string, bool> _errors = new Dictionary<string, bool>();

        private int _id;

        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
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
                if (BirthDate.HasValue)
                {
                    DateTime now = DateTime.Today;
                    int age = now.Year - BirthDate.Value.Year;
                    if (now < BirthDate.Value.AddYears(age)) age--;
                    return age;
                }
                else
                {
                    return null;
                }
            }
        }

        [XmlIgnore]
        public bool IsDirty { get; set; }

        [XmlIgnore]
        public bool HasErrors { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

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

        public void GetPropertyError(string propertyName, ErrorInfo info)
        {
            if (propertyName == "Age" || propertyName == "ApartmentNumber")
                return;

            if (propertyName == "Name" && string.IsNullOrEmpty(Name))
                info.ErrorText = @"Enter first name";
            if (propertyName == "LastName" && string.IsNullOrEmpty(LastName))
                info.ErrorText = @"Enter last name";
            if (propertyName == "StreetName" && string.IsNullOrEmpty(StreetName))
                info.ErrorText = @"Enter street name";
            if (propertyName == "HouseNumber" && string.IsNullOrEmpty(HouseNumber))
                info.ErrorText = @"Enter house number";
            if (propertyName == "PostalCode" && string.IsNullOrEmpty(PostalCode))
                info.ErrorText = @"Enter postal code";
            if (propertyName == "PostalCode" && !string.IsNullOrEmpty(PostalCode) && !Regex.Match(PostalCode, @"[0-9]{2}\-[0-9]{3}").Success)
                info.ErrorText = @"Postal code format should be: NN-NNN";
            if (propertyName == "Town" && string.IsNullOrEmpty(Town))
                info.ErrorText = @"Enter town";
            if (propertyName == "PhoneNumber" && string.IsNullOrEmpty(PhoneNumber))
                info.ErrorText = @"Enter phone number";
            if (propertyName == "BirthDate" && !BirthDate.HasValue)
                info.ErrorText = @"Enter birth date";

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

            HasErrors = _errors.Values.Count > 0 ? true : false;
        }

       
        public void GetError(ErrorInfo info)
        {}
    }
}
