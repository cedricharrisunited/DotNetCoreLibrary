using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace United.Services.FlightShopping.Common
{
    [Serializable]
    [DataContract]
    public class ShopRequest
    {
        #region Backing Fields

        private bool m_awardTravel = false;
        private bool m_calendarOnly = false;
        private bool m_decodesRequested = false;
        private bool m_decodesOnTimePerfRequested = false;
        private bool m_fareCalendar = false;
        //private bool m_fareFamilies = false;
        private bool m_fareMerchCalendar = false;
        private bool m_fareWheelOnly = false;
        private bool m_inclZeroAvailability = false;
        private bool m_inclAltTransportation = false;
        private bool m_inclCancelledFlights = true;
        private bool m_inclOAMain = true;
        private bool m_inclStarMain = true;
        private bool m_inclUACodeshares = true;
        private bool m_inclUAMain = true;
        private bool m_inclUARegionals = true;
        private bool m_initialShop = true;
        private bool m_ngrp = false;
        private bool m_oxygenCarrierProvided = false;
        private bool m_oxygenCustomerProvided = false;
        private int m_petCount = 0;
        private bool m_petTravel = false;
        private bool m_requeryForPassengerChange = false;
        private bool m_requeryForPOSChange = false;
        private bool m_requeryForUpsell = false;
        private bool m_sortTypeDescending = false;
        private bool m_stopsInclusive = true;
        private bool m_trueAvailability = true;
        private bool m_unaccompaniedMinor = false;
        private bool m_upgradeComplimentaryRequested = true;
        private bool m_fareMatrixOnly = false;
        private bool m_requeryForSession = false;

        #endregion

        #region Constructors

        public ShopRequest()
        {
            ServiceType = ServiceType.ValueNotSet;
            ApproxTimeOfDay = TimeOfDayType.ValueNotSet;
            CalendarLengthOfStay = -1;
            LangCode = "en-US";
            SearchType = AvailabilitySearchType.ValueNotSet;
            SearchTypeSelection = Common.SearchType.ValueNotSet;
        }

        #endregion

        #region Properties

        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public string AccessCode { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public string ApplicationId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public TimeOfDayType ApproxTimeOfDay { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool AwardTravel { get { return m_awardTravel; } set { m_awardTravel = value; } }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public string AuthenticationCode { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public BereavementType Bereavement { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public string BBXSolutionIdSelected { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public string BBXSolutionSetIdBookingDetails { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public string BBXSolutionSetIdSelected { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public string BookingCodesSpecified { get; set; }

        //[DataMember(EmitDefaultValue = false)]
        //[XmlAttribute]
        //public StaticModel.BundlesCode BundleProductCode { get; set; }

        //[DataMember(EmitDefaultValue = false)]
        //public Collection<Service.Presentation.CommonModel.Characteristic> Characteristics { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public string CabinPreferenceMain { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public string CalendarDateChange { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public int CalendarLengthOfStay { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool CalendarEconomyCallback { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool CalendarOnly { get { return m_calendarOnly; } set { m_calendarOnly = value; } }

        //[DataMember(EmitDefaultValue = false)]
        //public ResultFilters CalendarFilters { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public string CartId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public string ChannelType { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute("cool")]
        public bool CoolAwardSpecials { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public string CorporateTravelProvider { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public string CorporationName { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public string CountryCode { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public int CustomerId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool DecodesRequested { get { return m_decodesRequested; } set { m_decodesRequested = value; } }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool DecodesOnTimePerfRequested { get { return m_decodesOnTimePerfRequested; } set { m_decodesOnTimePerfRequested = value; } }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public string DepartDateTime { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public string Destination { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public string DeviceType { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool DisableMostRestrictive { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool DisablePricingBySlice { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool EditSearch { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public int EliteLevel { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public string EmployeeDiscountId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool FareCalendar { get { return m_fareCalendar; } set { m_fareCalendar = value; } }
        //[DataMember(EmitDefaultValue = false)]
        //public bool FareFamilies { get { return m_fareFamilies; } set { m_fareFamilies = value; } }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool FareMerchCalendar { get { return m_fareMerchCalendar; } set { m_fareMerchCalendar = value; } }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public string FareWheelDateChange { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool FareWheelOnly { get { return m_fareWheelOnly; } set { m_fareWheelOnly = value; } }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public int FlexibleDaysAfter { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public int FlexibleDaysBefore { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public string FlightNumber { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool InclAltTransportation { get { return m_inclAltTransportation; } set { m_inclAltTransportation = value; } }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool IncludeAmenities { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool InclCancelledFlights { get { return m_inclCancelledFlights; } set { m_inclCancelledFlights = value; } }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool IncludeLmx { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool InclOAMain { get { return m_inclOAMain; } set { m_inclOAMain = value; } }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool InclStarMain { get { return m_inclStarMain; } set { m_inclStarMain = value; } }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool InclUACodeshares { get { return m_inclUACodeshares; } set { m_inclUACodeshares = value; } }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool InclUAMain { get { return m_inclUAMain; } set { m_inclUAMain = value; } }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool InclUARegionals { get { return m_inclUARegionals; } set { m_inclUARegionals = value; } }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool InclZeroAvailability { get { return m_inclZeroAvailability; } set { m_inclZeroAvailability = value; } }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool InitialShop { get { return m_initialShop; } set { m_initialShop = value; } }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool InvokeAuxiliaryData { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool IsSearchInjection { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public string LangCode { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public int LastTripIndex { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public string LoyaltyId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public int MaxConnectTimeMinutes { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int MaxTrips { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public int MinConnectTimeMinutes { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public string Origin { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool OxygenCarrierProvided { get { return m_oxygenCarrierProvided; } set { m_oxygenCarrierProvided = value; } }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool OxygenCustomerProvided { get { return m_oxygenCustomerProvided; } set { m_oxygenCustomerProvided = value; } }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public string MilitaryStateCode { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public MilitaryTravelType MilitaryTravelType { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool NGRP { get { return m_ngrp; } set { m_ngrp = value; } }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public int PageIndex { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public int PageSize { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public int PetCount { get { return m_petTravel ? m_petCount : 0; } set { m_petCount = value; } }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool PetTravel { get { return m_petTravel; } set { m_petTravel = value; } }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public string PromoCode { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public string PromoLastName { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public string PromoDiscountCurrency { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public decimal PromoDiscountLowerBound { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public string PromoDiscountTicketDesignator { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public decimal PromoDiscountValue { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public string PromoPIN { get; set; }


        //[DataMember(EmitDefaultValue = false)]
        //public PricingOptions PricingOptions { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public string QueryType { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public string RecentSearchKey { get; set; }
        [XmlAttribute]
        public string RememberedLoyaltyId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool RequeryForPassengerChange { get { return m_requeryForPassengerChange; } set { m_requeryForPassengerChange = value; } }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool RequeryForPOSChange { get { return m_requeryForPOSChange; } set { m_requeryForPOSChange = value; } }


        //[DataMember(EmitDefaultValue = false)]
        //public United.Service.Presentation.ReservationModel.Reservation reservation { get; set; }


        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool RequeryForUpsell { get { return m_requeryForUpsell; } set { m_requeryForUpsell = value; } }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool RequestMileageDistance { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public string RiskFreePolicy { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public string ScreenSize { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public SearchOptions SearchOptions { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public int SearchFailoverDays { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public AvailabilitySearchType SearchType { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public SearchType SearchTypeSelection { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public ServiceType ServiceType { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public string SessionId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool SimpleSearch { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public string SortType { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool SortTypeDescending { get { return m_sortTypeDescending; } set { m_sortTypeDescending = value; } }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public int StartIndex { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public int Stops { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool StopsInclusive { get { return m_stopsInclusive; } set { m_stopsInclusive = value; } }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool TrueAvailability { get { return m_trueAvailability; } set { m_trueAvailability = value; } }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool UnaccompaniedMinor { get { return m_unaccompaniedMinor; } set { m_unaccompaniedMinor = value; } }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool UpgradeComplimentaryRequested { get { return m_upgradeComplimentaryRequested; } set { m_upgradeComplimentaryRequested = value; } }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public string VendorGUID { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string VendorName { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public bool VendorQuery { get; set; }

        //[DataMember(EmitDefaultValue = false)]
        //public List<Carrier> MarketingCarriers { get; set; }
        //[DataMember(EmitDefaultValue = false)]
        //public List<Carrier> OperatingCarriers { get; set; }
        //[DataMember(EmitDefaultValue = false)]
        //public List<Airport> Midpoints { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<string> Routes { get; set; }
        //[DataMember(EmitDefaultValue = false)]
        //public List<PaxInfo> PaxInfoList { get; set; }
        //[DataMember(EmitDefaultValue = false)]
        //public SpecialPricing.SpecialPricingInfo SpecialPricingInfo { get; set; }


        //[DataMember(EmitDefaultValue = false)]
        //public List<ClassOfService> RequiredAvailabilitySumAllFlights { get; set; }
        //[DataMember(EmitDefaultValue = false)]
        //public List<Trip> Trips { get; set; }


        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public string PartnerCardTypes { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<string> UpgradeTypes { get; set; }


        //[DataMember(EmitDefaultValue = false)]
        //public Service.Presentation.PersonModel.LoyaltyPerson LoyaltyPerson { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool IsPreferredBankCardHolder { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool InvokeShopAsynch { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool FareMatrixOnly { get { return m_fareMatrixOnly; } set { m_fareMatrixOnly = value; } }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool RequeryForSession { get { return m_requeryForSession; } set { m_requeryForSession = value; } }
        #region Properties - ReShop
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public string ConfirmationID { get; set; }
        #endregion

        public int BBxEliteLevel
        {
            get
            {
                return EliteLevel;
                //return EliteLevel == 0 && IsPreferredBankCardHolder
                //           ? (int)LoyaltyProgramMemberTierLevel.PremierGold
                //           : EliteLevel;
            }
        }
        #endregion

        //// For the task 370374 and 330546 added this new property
        #region CompassSortFilter
        //[DataMember(EmitDefaultValue = false)]
        //public OrganizeResultsRequest OrganizeSearchFilter { get; set; }

        #endregion
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public string CorporateAccessToken { get; set; }

        #region Methods

        public ShopRequest Clone()
        {
            ShopRequest sr = new ShopRequest()
            {
                AccessCode = this.AccessCode,
                ApplicationId = this.ApplicationId,
                ApproxTimeOfDay = this.ApproxTimeOfDay,
                AuthenticationCode = this.AuthenticationCode,
                AwardTravel = this.AwardTravel,
                BBXSolutionIdSelected = this.BBXSolutionIdSelected,
                BBXSolutionSetIdBookingDetails = this.BBXSolutionSetIdBookingDetails,
                BBXSolutionSetIdSelected = this.BBXSolutionSetIdSelected,
                BookingCodesSpecified = this.BookingCodesSpecified,
                CabinPreferenceMain = this.CabinPreferenceMain,
                CalendarDateChange = this.CalendarDateChange,
                CalendarLengthOfStay = this.CalendarLengthOfStay,
                CalendarOnly = this.CalendarOnly,
                CalendarEconomyCallback = this.CalendarEconomyCallback,
                CartId = this.CartId,
                ChannelType = this.ChannelType,
                ConfirmationID = this.ConfirmationID,
                CountryCode = this.CountryCode,
                CustomerId = this.CustomerId,
                DecodesRequested = this.DecodesRequested,
                DecodesOnTimePerfRequested = this.DecodesOnTimePerfRequested,
                DepartDateTime = this.DepartDateTime,
                Destination = this.Destination,
                DeviceType = this.DeviceType,
                DisableMostRestrictive = this.DisableMostRestrictive,
                EliteLevel = this.EliteLevel,
                EmployeeDiscountId = this.EmployeeDiscountId,
                FareCalendar = this.FareCalendar,
                //FareFamilies = this.FareFamilies,
                FareMerchCalendar = this.FareMerchCalendar,
                FareWheelDateChange = this.FareWheelDateChange,
                FareWheelOnly = this.FareWheelOnly,
                FlexibleDaysAfter = this.FlexibleDaysAfter,
                FlexibleDaysBefore = this.FlexibleDaysBefore,
                FlightNumber = this.FlightNumber,
                InclAltTransportation = this.InclAltTransportation,
                InclCancelledFlights = this.InclCancelledFlights,
                InclOAMain = this.InclOAMain,
                InclStarMain = this.InclStarMain,
                InclUACodeshares = this.InclUACodeshares,
                InclUAMain = this.InclUAMain,
                InclUARegionals = this.InclUARegionals,
                InclZeroAvailability = this.InclZeroAvailability,
                InitialShop = this.InitialShop,
                LangCode = this.LangCode,
                LoyaltyId = this.LoyaltyId,
                MaxConnectTimeMinutes = this.MaxConnectTimeMinutes,
                MaxTrips = this.MaxTrips,
                MilitaryTravelType = this.MilitaryTravelType,
                MilitaryStateCode = this.MilitaryStateCode,
                MinConnectTimeMinutes = this.MinConnectTimeMinutes,
                NGRP = this.NGRP,
                Origin = this.Origin,
                OxygenCarrierProvided = this.OxygenCarrierProvided,
                OxygenCustomerProvided = this.OxygenCustomerProvided,
                PageIndex = this.PageIndex,
                PageSize = this.PageSize,
                PetCount = this.PetCount,
                PetTravel = this.PetTravel,
                PromoCode = this.PromoCode,
                PromoDiscountCurrency = this.PromoDiscountCurrency,
                PromoDiscountLowerBound = this.PromoDiscountLowerBound,
                PromoDiscountTicketDesignator = this.PromoDiscountTicketDesignator,
                PromoDiscountValue = this.PromoDiscountValue,
                PromoPIN = this.PromoPIN,
                QueryType = this.QueryType,
                RequeryForPOSChange = this.RequeryForPOSChange,
                RequestMileageDistance = this.RequestMileageDistance,
                RequeryForUpsell = this.RequeryForUpsell,
                SearchFailoverDays = this.SearchFailoverDays,
                SearchType = this.SearchType,
                SearchTypeSelection = this.SearchTypeSelection,
                ServiceType = this.ServiceType,
                SessionId = this.SessionId,
                SortType = this.SortType,
                SortTypeDescending = this.SortTypeDescending,
                StartIndex = this.StartIndex,
                Stops = this.Stops,
                StopsInclusive = this.StopsInclusive,
                TrueAvailability = this.TrueAvailability,
                UnaccompaniedMinor = this.UnaccompaniedMinor,
                VendorGUID = this.VendorGUID,
                VendorName = this.VendorName,
                CoolAwardSpecials = this.CoolAwardSpecials,
                SearchOptions = this.SearchOptions // Task 366999 Compass overbooking                
            };

            //try
            //{
            //    sr.CalendarFilters = CalendarFilters;
            //}
            //catch (Exception)
            //{

            //    throw;
            //}

            //if (this.MarketingCarriers != null)
            //{
            //    sr.MarketingCarriers = new List<Carrier>();
            //    foreach (Carrier c in this.MarketingCarriers)
            //    {
            //        sr.MarketingCarriers.Add(c.Clone());
            //    }
            //}
            //if (this.OperatingCarriers != null)
            //{
            //    sr.OperatingCarriers = new List<Carrier>();
            //    foreach (Carrier c in this.OperatingCarriers)
            //    {
            //        sr.OperatingCarriers.Add(c.Clone());
            //    }
            //}
            //if (this.Midpoints != null)
            //{
            //    sr.Midpoints = new List<Airport>();
            //    foreach (Airport a in this.Midpoints)
            //    {
            //        sr.Midpoints.Add(a.Clone());
            //    }
            //}
            //if (this.PaxInfoList != null)
            //{
            //    sr.PaxInfoList = new List<PaxInfo>();
            //    foreach (PaxInfo p in this.PaxInfoList)
            //    {
            //        sr.PaxInfoList.Add(p.Clone());
            //    }
            //}
            //if (this.RequiredAvailabilitySumAllFlights != null)
            //{
            //    sr.RequiredAvailabilitySumAllFlights = new List<ClassOfService>();
            //    foreach (ClassOfService c in this.RequiredAvailabilitySumAllFlights)
            //    {
            //        sr.RequiredAvailabilitySumAllFlights.Add(c.Clone());
            //    }
            //}
            //if (this.Routes != null)
            //{
            //    sr.Routes = new List<string>();
            //    foreach (string s in this.Routes)
            //    {
            //        sr.Routes.Add(s);
            //    }
            //}
            //if (this.SpecialPricingInfo != null)
            //{
            //    sr.SpecialPricingInfo = null;// CommonStaticMethods.CloneDeep<SpecialPricing.SpecialPricingInfo>(this.SpecialPricingInfo);
            //}
            //if (this.Trips != null)
            //{
            //    //sr.Trips = new List<Trip>();
            //    //foreach (Trip t in this.Trips)
            //    //{
            //    //    sr.Trips.Add(t.Clone());
            //    //}
            //}
            //if (this.UpgradeTypes != null)
            //{
            //    sr.UpgradeTypes = null; // CommonStaticMethods.CloneDeep<List<string>>(this.UpgradeTypes);
            //}
            //if (this.reservation != null)
            //{
            //    sr.reservation = this.reservation.CloneDeep();
            //}

            ////// this property is added for the task 370374, 330546
            //if (this.OrganizeSearchFilter != null)
            //{
            //    sr.OrganizeSearchFilter = this.OrganizeSearchFilter.CloneDeep(); // For Compass Sorting
            //}

            return sr;
        }

        #endregion


    }

    [Serializable]
    [DataContract]
    public class SearchOptions
    {
        [DataMember(EmitDefaultValue = false)]
        public List<string> OverBookingCodes { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool AllowFlownFlights { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool AllowUnavailableFlights { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [XmlAttribute]
        public bool DisableAvailabilityCheck { get; set; }
    }
}

