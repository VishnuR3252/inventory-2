namespace InventoryService.Infrastructure.Persistence;

using System.Threading.Tasks;
using CommonService.Helpers;
using InventoryService.Application.Interfaces.IPersistence;
using InventoryService.Domain.Entities;
using InventoryService.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

public class UnitRepository(ApplicationDbContext dbContext, IUserContext userContext) : IUnitRepository
{
    private readonly ApplicationDbContext _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
    private readonly IUserContext _userContext = userContext ?? throw new ArgumentNullException(nameof(userContext));

    public async Task AddUnitAsync(Unit unit)
    {
        unit.CreatedBy = _userContext.UserId;
        await _dbContext.Units.AddAsync(unit);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateUnitAsync(Unit unit)
    {
        _dbContext.Units.Update(unit);
        await _dbContext.SaveChangesAsync();
    }

    public IQueryable<Unit> GetAllUnits()
    {
        return _dbContext.Units.AsNoTracking().Where(a => !a.IsDeleted).AsQueryable()
            .OrderBy(a => a.Name);
    }
}
