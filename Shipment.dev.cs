
namespace Assigment.Net.OOP5
{
    public abstract partial class Shipment
    {

        public string TrackingStatus { get; private set; } = string.Empty;

        public string GetTrackingStatus()
        {
            return TrackingStatus;
        }

        public void UpdateTrackingStatus(string newStatus)
        {
            TrackingStatus = newStatus;
            OnTrackingStatusChanged(newStatus);
        }

        partial void OnTrackingStatusChanged(string newStatus);
    }
}
