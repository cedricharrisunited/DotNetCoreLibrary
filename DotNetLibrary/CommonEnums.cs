using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace United.Services.FlightShopping.Common
{
    [Serializable]
    [DataContract]
    public enum AvailabilityFareType
    {
        [EnumMember]
        ValueNotSet,
        [EnumMember]
        FullFare,
        [EnumMember]
        LowestAvailable,
        [EnumMember]
        LowestRefundable,
        [EnumMember]
        SpecificClassesOfService,
        [EnumMember]
        PassPlusSecureOnly
    }

    [Serializable]
    [DataContract]
    public enum AvailabilitySearchType
    {
        [EnumMember]
        ValueNotSet,
        [EnumMember]
        Reissue,
        [EnumMember]
        RevenuePrice,
        [EnumMember]
        RevenuePriceCalendar,
        [EnumMember]
        RevenueSchedule,
        [EnumMember]
        RevenueScheduleCalendar,
        [EnumMember]
        Reward,
        [EnumMember]
        RevenuePriceBundled,
        [EnumMember]
        RevenueScheduleBundled
    }

    [Serializable]
    [DataContract]
    public enum AvailabilitySortType
    {
        [EnumMember]
        Default,
        [EnumMember]
        AeroSchedule,
        [EnumMember]
        DepartTime,
        [EnumMember]
        DestinationTime,
        [EnumMember]
        OnePassMileage,
        [EnumMember]
        Organized,
        [EnumMember]
        Price,
        [EnumMember]
        PriceByColumn,
        [EnumMember]
        RewardOrganized,
        [EnumMember]
        Schedule,
        [EnumMember]
        Stops,
        [EnumMember]
        StopsByColumn,
        [EnumMember]
        TravelTime
    }

    [Serializable]
    [DataContract]
    public enum BereavementType
    {
        [EnumMember]
        NoneSelected,
        [EnumMember]
        Death,
        [EnumMember]
        Escort,
        [EnumMember]
        Illness
    }

    [Serializable]
    [DataContract]
    public enum CabinType
    {
        [EnumMember]
        ValueNotSet,
        [EnumMember]
        Business,
        [EnumMember]
        BusinessFirst,
        [EnumMember]
        Coach,
        [EnumMember]
        First
    };

    [Serializable]
    [DataContract]
    public enum CartItemTypes
    {
        [EnumMember]
        ValueNotSet,
        [EnumMember]
        Reservation,
        [EnumMember]
        SeatAssignments,
        [EnumMember]
        FareLock,
        [EnumMember]
        PetInCabin,
        [EnumMember]
        UnaccompaniedMinor,
        [EnumMember]
        TripInsurance,
        [EnumMember]
        MilesPurchase,
        [EnumMember]
        AwardCloseInFee,
        [EnumMember]
        OnlineBookingFee,
        [EnumMember]
        AirportPassengerDuty
    };


    [Serializable]
    [DataContract]
    public enum DayFareType
    {
        [EnumMember]
        ValueNotSet,
        [EnumMember]
        BASE,
        [EnumMember]
        FIRST,
        [EnumMember]
        FIRSTCLASS,
        [EnumMember]
        REFUNDABLE,
        [EnumMember]
        CHEAPEST,
        [EnumMember]
        UNRESTRICTED
    };

    [Serializable]
    [DataContract]
    public enum EUpgradeOption
    {
        [EnumMember]
        None,
        [EnumMember]
        All,
        [EnumMember]
        GPU,
        [EnumMember]
        RPU
    }

    [Serializable]
    [DataContract]
    public enum EUpgradeSelection
    {
        [EnumMember]
        None,
        [EnumMember]
        GPU,
        [EnumMember]
        RPU,
        [EnumMember]
        MUA,
        [EnumMember]
        CPU,
        YBM
    }

    /// <summary>
    /// Defines the special conditions that can be associated with a flight.
    /// </summary>
    [Serializable]
    [DataContract]
    [Flags]
    public enum IndicatorValues : int
    {
        /// <summary>
        /// There are no special conditions associated with this flight.
        /// </summary>
        [EnumMember]
        None = 0,

        /// <summary>
        /// Audio/video on-demand service is available on this flight.
        /// </summary>
        [EnumMember]
        AudioVideoOnDemand = 1,

        /// <summary>
        /// Beverages are served on this flight.
        /// </summary>
        [EnumMember]
        Beverages = 2,

        /// <summary>
        /// DirecTV service is available on this flight.
        /// </summary>
        [EnumMember]
        DirecTV = 4,

        /// <summary>
        /// Meals are served to economy-class travelers on this flight.
        /// </summary>
        [EnumMember]
        EconomyMeal = 8,

        /// <summary>
        /// Economy-class lie-flat seating is available on this flight.
        /// </summary>
        [EnumMember]
        EconomyLieFlatSeating = 16,

        /// <summary>
        /// FareLock service is available for this flight.
        /// </summary>
        [EnumMember]
        FareLock = 32,

        /// <summary>
        /// Meals are served to first-class travelers on this flight.
        /// </summary>
        [EnumMember]
        FirstClassMeal = 64,

        /// <summary>
        /// First-class lie-flat seating is available on this flight.
        /// </summary>
        [EnumMember]
        FirstClassLieFlatSeating = 128,

        /// <summary>
        /// In-seat power outlets are available on this flight.
        /// </summary>
        [EnumMember]
        InseatPower = 256,

        /// <summary>
        /// In-cabin pets are not allowed on this flight.
        /// </summary>
        [EnumMember]
        PetsDisallowed = 512,

        /// <summary>
        /// Wi-Fi internet service is available on this flight.
        /// </summary>
        [EnumMember]
        WiFi = 1024
    }

    [Serializable]
    [DataContract]
    public enum MilitaryTravelType
    {
        [EnumMember]
        NotSet,
        [EnumMember]
        Federal,
        [EnumMember]
        Leisure,
        [EnumMember]
        State
    }

    [Serializable]
    [DataContract]
    public enum PassPlusType
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        Flex = 1,
        [EnumMember]
        Secure = 2,
    }

    [Serializable]
    [DataContract]
    public enum PaxType
    {
        [EnumMember]
        ValueNotSet,
        [EnumMember]
        Adult,
        [EnumMember]
        Child01,
        [EnumMember]
        Child02,
        [EnumMember]
        Child03,
        [EnumMember]
        InfantLap,
        [EnumMember]
        InfantSeat,
        [EnumMember]
        Senior,
        [EnumMember]
        Child04 = 8, //Age 12-15
        [EnumMember]
        Child05 = 9 //Age 16-17 
    };

    [Serializable]
    [DataContract]
    public enum PersistObjects
    {
        [EnumMember]
        BookingDetails,
        [EnumMember]
        DisplayCart,
        [EnumMember]
        FormsOfPaymentRequest,
        [EnumMember]
        Reservation,
        [EnumMember]
        ShoppingCart,
        [EnumMember]
        ShopRequest,
        [EnumMember]
        ShopResponse,
        [EnumMember]
        SessionStorage,
        [EnumMember]
        TPIProductModel,
        [EnumMember]
        ProductOffers,
        [EnumMember]
        FlightAuxiliary,
        [EnumMember]
        LmxQuoteResponse,
        [EnumMember]
        ShoppingCartItems,
        [EnumMember]
        TravelOptions,
        [EnumMember]
        OriginalShopRequest,
        [EnumMember]
        SeatAssignment,
        [EnumMember]
        OriginalReservation,
        [EnumMember]
        SFSReservation,
        [EnumMember]
        WaivedRequest,
        [EnumMember]
        ProductBundles,
        [EnumMember]
        MPF,
        [EnumMember]
        FlightReservationResponse,
        [EnumMember]
        UpgradeSegmentDetail
    }

    // was Flight.CommonObjects.Price.PriceTypes
    [Serializable]
    [DataContract]
    public enum PriceType
    {
        [EnumMember]
        ValueNotSet,
        [EnumMember]
        AdjustedTotal,
        [EnumMember]
        AirportDepartureTax,
        [EnumMember]
        BalanceDue,
        [EnumMember]
        BrokenOutTax,
        [EnumMember]
        CallCenterFee,
        [EnumMember]
        EcdPromotion,
        [EnumMember]
        ExchangeFee,
        [EnumMember]
        FuelSurcharge,
        [EnumMember]
        GiftCertificate,
        [EnumMember]
        MileageDueOrRefund,
        [EnumMember]
        MPUpgrade,          // added 20130822 - CSM
        [EnumMember]
        MPUpgradeMileage,   // added 20130822 - CSM
        [EnumMember]
        OnlineBookingFee,
        [EnumMember]
        PCUpgradeFee,
        [EnumMember]
        PetFee,
        [EnumMember]
        PremierAccessFee,
        [EnumMember]
        RedepositFee,
        [EnumMember]
        Refund,
        [EnumMember]
        RevenueUpgradeFee,
        [EnumMember]
        SubTotal,
        [EnumMember]
        Tax,
        [EnumMember]
        Total,
        [EnumMember]
        TravelBankCash,
        [EnumMember]
        TravelerEntry,
        [EnumMember]
        TripInsuranceFee,
        [EnumMember]
        UnaccompaniedMinorFee
    }

    [Serializable]
    [DataContract]
    public enum PromoType
    {
        [EnumMember]
        ValueNotSet,
        [EnumMember]
        FOP,
        [EnumMember]
        MeetingWorks,
        [EnumMember]
        MultiLevel,
        [EnumMember]
        Offer,
        [EnumMember]
        OnePass,
        [EnumMember]
        PromotionDiscount,
        [EnumMember]
        Ticket,
        [EnumMember]
        Upgrade,
        [EnumMember]
        Null,
        [EnumMember]
        CorporateDiscount
    }

    [Serializable]
    [DataContract]
    public enum ResourceCallType
    {
        [EnumMember]
        Revenue,
        [EnumMember]
        Reward,
        [EnumMember]
        RewardCalendarCoach,
        [EnumMember]
        RewardCalendarFirst,
        [EnumMember]
        FlexibleDates,
        [EnumMember]
        NearbyAirports,
        [EnumMember]
        LowestRefundable,
        [EnumMember]
        FirstClass,
        [EnumMember]
        FullPinDownRevenue,
        [EnumMember]
        TimeTableSmartError,
        [EnumMember]
        AirportAlternate,
        [EnumMember]
        EcdTicketCalendar,
        [EnumMember]
        EcdOffer,
        [EnumMember]
        EcdMultiLevel,
        [EnumMember]
        EcdUpgrade,
        [EnumMember]
        EcdTicket,
        [EnumMember]
        RewardNonStopRequery,
        [EnumMember]
        RevenueNonStopRequery,
        [EnumMember]
        PfseQuery,
        [EnumMember]
        TotalCallTime,
        [EnumMember]
        AutoFlexibleDates,
        [EnumMember]
        FareCalendar,
        [EnumMember]
        FareMerchandisingCalendar,
        [EnumMember]
        RevenuePriceCalendar,
        [EnumMember]
        RevenueScheduleCalendar
    }

    [Serializable]
    [DataContract]
    public enum RewardCode
    {
        [EnumMember]
        ValueNotSet,
        [EnumMember]
        BusinessEasy,
        [EnumMember]
        BusinessStandard,
        [EnumMember]
        EcnEasy,
        [EnumMember]
        EcnStan,
        [EnumMember]
        FirstEasy,
        [EnumMember]
        FirstStan,
        [EnumMember]
        MoneyMiles
    };

    [Serializable]
    [DataContract]
    public enum SearchType
    {
        [EnumMember]
        ValueNotSet = 0,
        [EnumMember]
        OneWay = 1,
        [EnumMember]
        RoundTrip = 2,
        [EnumMember]
        MultipleDestination = 3
    };

    [Serializable]
    [DataContract]
    public enum SellupAmountRule
    {
        [EnumMember]
        GreaterThan = 1,
        [EnumMember]
        LessThan = 2,
        [EnumMember]
        NotEqual = 3,
        [EnumMember]
        NotOffered = 4,
        [EnumMember]
        Equal = 5
    }

    [Serializable]
    [DataContract]
    public enum SellupFareType
    {
        [EnumMember]
        ValueNotSet,
        [EnumMember]
        Base,
        [EnumMember]
        Business,
        [EnumMember]
        EasyPassCoach,
        [EnumMember]
        EasyPassFirst,
        [EnumMember]
        First,
        [EnumMember]
        FullY,
        [EnumMember]
        NonRefundableCoach,
        [EnumMember]
        NonRefundableFirst,
        [EnumMember]
        Refundable,
        [EnumMember]
        RefundableCoach,
        [EnumMember]
        RefundableFirst,
        [EnumMember]
        StandardCoach,
        [EnumMember]
        StandardFirst
    };

    [Serializable]
    [DataContract]
    public enum SellupSearchType
    {
        [EnumMember]
        LowestAvailable = 1,
        [EnumMember]
        LowestRefundable = 2,
        [EnumMember]
        FullFare = 3,
        [EnumMember]
        ClassOfService = 4,
        [EnumMember]
        First = 5,
        [EnumMember]
        Reward = 6,
        [EnumMember]
        OnePassMileageUpgrade = 7
    };

    [Serializable]
    [DataContract]
    public enum SegmentFeatureAction
    {
        [EnumMember]
        ValueNotSet,
        [EnumMember]
        OptOut,
        [EnumMember]
        OptIn
    }

    [Serializable]
    [DataContract]
    public enum SegmentFeatureType
    {
        [EnumMember]
        ValueNotSet,
        [EnumMember]
        YBM,
        GPU,
        RPU,
        MUA
    }


    // this is used for debug/internal purposes only
    [Serializable]
    [DataContract]
    public enum ServerType
    {
        [EnumMember]
        ValueNotSet,
        [EnumMember]
        Dev,
        [EnumMember]
        Stg,
        [EnumMember]
        PreProd,
        [EnumMember]
        Prod,
        [EnumMember]
        ProdPerf,
    }

    [Serializable]
    [DataContract]
    public enum ServiceType
    {
        [EnumMember]
        ValueNotSet,
        [EnumMember]
        Boombox,
        [EnumMember]
        NGRP,
        [EnumMember]
        Schedule,
        [EnumMember]
        VendorServices,
        [EnumMember]
        ReShop
    }

    [Serializable]
    [DataContract]
    public enum StatusType
    {
        [EnumMember]
        Failure,
        [EnumMember]
        Success
    }

    [Serializable]
    [DataContract]
    public enum TimeOfDayType
    {
        [EnumMember]
        ValueNotSet,
        [EnumMember]
        Midnight,
        [EnumMember]
        MorningEarly,
        [EnumMember]
        Morning,
        [EnumMember]
        MorningLate,
        [EnumMember]
        Noon,
        [EnumMember]
        Afternoon,
        [EnumMember]
        Evening,
        [EnumMember]
        EveningLate
    }

    [Serializable]
    [DataContract]
    public enum TranslatedState
    {
        [EnumMember]
        TRANSLATING,
        [EnumMember]
        DONE,
        [EnumMember]
        FAILED
    }

    [Serializable]
    [DataContract]
    public enum UpgradeProgram
    {
        [EnumMember]
        MileagePlus = 1,
        [EnumMember]
        SAUA = 2,
        [EnumMember]
        EUA = 3,
        [EnumMember]
        ConfirmedElite = 4,
        [EnumMember]
        SWU = 5,
        [EnumMember]
        RPU = 6,
        [EnumMember]
        GPU = 7
    };

    [Serializable]
    [DataContract]
    public enum UpgradeMessageValues
    {
        [EnumMember]
        ValueNotSet,
        [EnumMember]
        UPGRADINGTYPE,
        [EnumMember]
        UPGRADINGORIGINALCLASS,
        [EnumMember]
        UPGRADINGUPGRADECLASS,
        [EnumMember]
        YBMWAITLISTED
    };
}

