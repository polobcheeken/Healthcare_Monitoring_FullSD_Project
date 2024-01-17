namespace HealthCareMonitoring.Client.Static
{

    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string AppointmentsEndpoint = $"{Prefix}/appointments";
        public static readonly string ConsultationsEndpoint = $"{Prefix}/consultations";
        public static readonly string HospitalsEndpoint = $"{Prefix}/hospitals";
        public static readonly string MedicinesEndpoint = $"{Prefix}/medicines";
        public static readonly string PatientsEndpoint = $"{Prefix}/patients";
<<<<<<< HEAD
        public static readonly string PrescriptionsEndpoint = $"{Prefix}/prescriptions";
=======
        public static readonly string PrescriptionEndpoint = $"{Prefix}/prescriptions";
>>>>>>> 5eb0dad489109e8062baaa3f6fb89913533d6b0d
        public static readonly string PrescriptionItemsEndpoint = $"{Prefix}/prescriptionitems";
        public static readonly string StaffsEndpoint = $"{Prefix}/staffs";
        public static readonly string PaymentsEndpoint = $"{Prefix}/payments";
    }


}
