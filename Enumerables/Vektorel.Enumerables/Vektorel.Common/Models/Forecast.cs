namespace Vektorel.Common.Models
{
    public record Forecast(decimal Heat, 
                           decimal UV, 
                           decimal Humidity, 
                           decimal WindSpeed, 
                           string Status);
}
//immutable