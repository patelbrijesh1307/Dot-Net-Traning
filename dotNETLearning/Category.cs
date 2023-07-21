using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNETLearning
{

    public enum Category
    {

    }
    public enum CategoryEnums : int
    {
        ASSETS = 1,
        LIABILITIES = 2,
        LOANS = 15,
        EQUITY = 5,
        DEBTS = 6,
        HYBRID = 7,
        REALESTATE = 8,
        GOLD = 9,
        SAFEDEPOSIT = 10,
        BANKACCOUNT = 11,
        PENSIONPLAN = 12,
        CRYPTOCURRENCY = 13,
        ASSETSOTHER = 14,
        INSURANCE = 17,
        INCOME = 3,
        USERRATIOS = 68,
        EXPENSELIABILITYMANAGEMENT = 69,
        EMERGENCYPLANNING = 71,
        ASSETSALLOCATION = 70,
        USERFINANCIALSCORE = 86,
        MARITALSTATUS = 92,
        EDUCATIONALQUALIFICATION = 96,
        LIFEINSURANCE = 63,
        CUSTOMERVERIFICATIONDETAILS = 128,
        REPORTS = 132,
        TAXREGIME = 135,
        MEETINGTYPE = 138,
        CUSTOMERJOURNEY = 144,
        MEETINGSTATUS = 160,
        PMWELL = 164,
        CREDITFACILITY = 170,
        FEATUREDLIST = 176,
        YOYGROWTH = 180,
        MONEYSIGN = 185,
        RIADETAILS = 197,
        LIABILITYTYPE = 212

    }

    public enum ASSETS : int
    {
        Equity = 5,
        Debt = 6,
        Hybrid = 7,
        RealEstate = 8,
        Gold = 9,
        SafeDeposit = 10,
        BankAccount = 11,
        PensionPlans = 12,
        CryptoCurrency = 13,
        Other = 14
    }

    public enum LIABILITIES : int
    {
        CreditCards = 16,
        Loans = 15,
        Insurance = 17,
        CreditScore = 159
    }

    public enum LOANS : int
    {
        AutoLoan = 55,
        PropertyLoan = 56,
        HousingLoan = 57,
        CarLoan = 58,
        PersonalLoan = 59,
        TwoWheelerLoan = 60,
        ConsumerLoan = 61,
        CreditCardLoan = 104,
        None = 142,
        EducationLoan = 175,
        GoldLoan = 208,
        OtherLoan = 209

    }

    public enum EQUITY : int
    {
        PublicStocksIndia = 18,
        EquityMutualFunds = 19,
        ModelPortfolio = 20,
        UnlistedStocks = 21,
        PublicStocksInternational = 22,
        EquityETFs = 23,
        InternationalFunds = 24,
        None = 121,
    }

    public enum DEBTS : int
    {
        DirectBonds = 25,
        LiquidDebtFunds = 26,
        DebtFunds = 27,
        FreeDebtInstruments = 54,
        None = 122
    }

    public enum HYBRID : int
    {
        Hybrid = 7
    }

    public enum REALESTATE : int
    {
        RentalYieldingResidential = 29,
        RentalYieldingCommercial = 30,
        NonYieldingResidential = 31,
        NonYieldingCommercial = 32,
        OccupiedHome = 33,
        None = 123
    }

    public enum GOLD : int
    {
        PhysicalGold = 34,
        GoldETFs = 35,
        SovereignGoldBonds = 36,
        PhysicalSilver = 90,
        SilverETFs = 91,
        None = 124
    }

    public enum SAFEDEPOSIT : int
    {
        BankFD = 37,
        CorporateFD = 38,
        PostOfficeMonthlyIncomeScheme = 39,
        SeniorCitizenSavingsScheme = 40,
        SukanyaSamriddhiYojana = 41,
        NationalSavingsCertificate = 42,
        EPF = 43,
        PPF = 44,
        None = 125
    }

    public enum BANKACCOUNT : int
    {
        Savings = 45
    }

    public enum PENSIONPLAN : int
    {
        NPSTierI = 46,
        NPSTierII = 47,
        PradhanMantriVayaVandanaYojana = 48,
        AtalPensionYojana = 49,
        None = 126
    }

    public enum CRYPTOCURRENCY : int
    {
        DirectCryptos = 50,
        CoinBaskets = 51,
        None = 127
    }

    public enum ASSETSOTHER : int
    {
        Other = 52,
        LoansGiven = 53,
        FreeDebtInstruments = 120
    }

    public enum CREDITCARDS : int
    {
        CreditCard = 62
    }

    public enum INSURANCE : int
    {
        LifeInsurance = 63,
        HealthInsurance = 64,
        Other = 103,
        None = 143
    }

    public enum INCOME : int
    {
        Salaried = 65,
        Business = 66,
        Other = 67
    }

    public enum USERRATIOS : int
    {
        ExpenseandLiabilityManagement = 69,
        AssetAllocation = 70,
        EmergencyPlanning = 71
    }

    public enum EXPENSELIABILITYMANAGEMENT : int
    {
        ExpenseLiabilityManagement = 69,
        GoodLiabilitiestoTotalAssets = 72,
        BadLiabilitiestoTotalAssets = 73,
        ExpensetoIncome = 74,
        GoodLiabilityLinkedEMItoIncome = 75,
        BadLiabilityLinkedEMItoIncome = 76,
        SavingstoIncome = 77

    }

    public enum ASSETSALLOCATION : int
    {
        AssetsAllocation = 70,
        Equity = 78,
        RealEstate = 79,
        PassiveIncomeAssets = 80,
        Debt = 81,
        AlternativeInvestments = 82
    }

    public enum EMERGENCYPLANNING : int
    {
        EmergencyPlanning = 71,
        EmergencyFunds = 83,
        HealthInsurance = 84,
        LifeInsurance = 85
    }

    public enum USERFINANCIALSCORE : int
    {
        TotalAssets = 87,
        TotalLiabilities = 88,
        Networth = 89
    }

    public enum MARITALSTATUS : int
    {
        MaritalStatus = 92,
        Married = 93,
        Unmarried = 94,
        Other = 95
    }

    public enum EDUCATIONALQUALIFICATION : int
    {
        EducationalQualification = 96,
        Matriculate = 97,
        Bachelors = 98,
        Masters = 99,
        Other = 100
    }

    public enum LIFEINSURANCE : int
    {
        TermInsurance = 101,
        Endowment = 102
    }

    public enum CUSTOMERVERIFICATIONDETAILS : int
    {
        PANNumber = 129,
        AadharNumber = 130,
        CAMPassword = 131
    }

    public enum REPORTS : int
    {
        FWPReports = 133,
        MemberReport = 134
    }

    public enum TAXREGIME
    {
        OldTaxRegime = 136,
        NewTaxRegime = 137
    }

    public enum MEETINGTYPE : int
    {
        Consultation = 139,
        FWPPresentation = 140,
        QuarterlyMeeting = 141
    }

    public enum CUSTOMERJOURNEY : int
    {
        AppointmentBooked = 145,
        MeetingSchedule = 146,
        MeetingReschedule = 147,
        MeetingCancel = 148,
        CustomerRejected = 149,
        CustomerOnboarded = 150,
        CustomerAssigned = 151,
        NDASent = 152,
        DataGatheringComplete = 153,
        DownloadCustomerReport = 154,
        GenerateCustomerReportRequestSent = 155,
        GenerateCustomerReport = 156

    }

    public enum MEETINGSTATUS : int
    {
        Pending = 161,
        Completed = 162,
        NotAttended = 163,
        NotInterested = 167,
        FutureProspect = 168,
        NotTG = 169
    }

    public enum PMWELL : int
    {
        IdealHealthInsurance = 165,
        IdealLifeInsurance = 166
    }

    public enum CREDITFACILITY : int
    {
        TotalRecords = 171,
        ActiveAccounts = 172,
        ClosedAccounts = 173,
        AccountswithNegativeHistory = 174
    }

    public enum FEATUREDLIST : int
    {
        TermInsurance = 177,
        HealthInsurance = 178,
        EquityMutualFunds = 179
    }

    public enum YOYGROWTH : int
    {
        Income = 181,
        Expense = 182
    }

    public enum GENERATION : int
    {
        Generation = 183
    }

    public enum ONEFINANCESCORE : int
    {
        OneFinanceScore = 184
    }

    public enum MONEYSIGN : int
    {
        Aggressiveness = 186,
        Anxiety = 187,
        Creativity = 188,
        Curiosity = 189,
        Discipline = 190,
        Hypercompetition = 191,
        Organization = 192,
        Patience = 193,
        Satisfaction = 194
    }

    public enum USERCURRENTYEARTAX : int
    {
        UserCurrentYearTax = 195
    }

    public enum MONEYSIGNDESCRIPTION : int
    {
        MoneySignDescription = 196
    }

    public enum RIADETAILS : int
    {
        VerifiedEmail = 198,
        VerifiedPAN = 199,
        KRAVerification = 200,
        CKYCNumber = 201,
        CKYCVerificationStatus = 202,
        PMLAVerification = 203,
        MCGVerification = 204,
        CustomerESign = 205,
        MemberIDGenerationStatus = 206,
        ESignDocumentID = 207
    }

    public enum TAXDEDUCTIONAMOUNT : int
    {
        TaxDeductionAmount = 211
    }

    public enum LIABILITYTYPE : int
    {
        Good = 213,
        Bad = 214
    }


}
