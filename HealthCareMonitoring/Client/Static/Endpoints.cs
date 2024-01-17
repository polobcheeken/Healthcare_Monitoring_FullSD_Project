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
        public static readonly string PrescriptionEndpoint = $"{Prefix}/prescriptions";
        public static readonly string PrescriptionItemsEndpoint = $"{Prefix}/prescriptionitems";
        public static readonly string StaffsEndpoint = $"{Prefix}/staffs";
    }


}
