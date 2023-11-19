using DemoAppDotNet7.Models.Contract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace DemoAppDotNet7.Data.Interceptors
{
    public class SoftDeleteInterceptor : SaveChangesInterceptor
    {
        public override ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default)
        {
            if (eventData.Context is null)
                return base.SavingChangesAsync(eventData, result, cancellationToken);

            foreach (var entry in eventData.Context.ChangeTracker.Entries())
            {
                //if (entry is null || entry.State != EntityState.Deleted ||! (entry.Entity is ISoftDeleteable))
                if (entry is not { State: EntityState.Deleted, Entity: ISoftDeleteable entity })
                    continue;
                entry.State = EntityState.Modified;

                entity.Delete();
            }
            return base.SavingChangesAsync(eventData, result, cancellationToken);
        }
    }
}