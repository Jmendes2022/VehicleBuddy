﻿using VehicleBuddy.Server.Models;

namespace VehicleBuddy.Server.Repositories.Interfaces;

public interface IVehicleRepository
{
    Task DeleteAsync(int vehicleId);
    Task<IList<Vehicle>> GetAllAsync();
    Task<Vehicle?> GetAsync(int vehicleId);
    Task<Vehicle?> GetByVinAsync(string vin, bool includeSold);
    Task SaveAsync(Vehicle vehicle);
    Task SaveImagesAsync(List<Image> images);
}