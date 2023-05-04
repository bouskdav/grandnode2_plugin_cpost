using Grand.Domain;
using Grand.Domain.Data;
using Grand.Infrastructure.Caching;

namespace Shipping.CPost.Services
{
    public partial class CPostShippingService : ICPostShippingService
    {
        //#region Constants
        //private const string SHIPPINGBYWEIGHT_ALL_KEY = "Grand.shippingbyweight.all-{0}-{1}";
        //private const string SHIPPINGBYWEIGHT_PATTERN_KEY = "Grand.shippingbyweight.";
        //#endregion

        //#region Fields

        //private readonly IRepository<CPostShippingRecord> _sbwRepository;
        //private readonly ICacheBase _cacheBase;

        //#endregion

        //#region Ctor

        //public CPostShippingService(ICacheBase cacheBase,
        //    IRepository<CPostShippingRecord> sbwRepository)
        //{
        //    _cacheBase = cacheBase;
        //    _sbwRepository = sbwRepository;
        //}

        //#endregion

        //#region Methods

        //public virtual async Task DeleteCPostShippingRecord(CPostShippingRecord shippingCPostRecord)
        //{
        //    if (shippingCPostRecord == null)
        //        throw new ArgumentNullException(nameof(shippingCPostRecord));

        //    await _sbwRepository.DeleteAsync(shippingCPostRecord);

        //    await _cacheBase.RemoveByPrefix(SHIPPINGBYWEIGHT_PATTERN_KEY);
        //}

        //public virtual async Task<IPagedList<CPostShippingRecord>> GetAll(int pageIndex = 0, int pageSize = int.MaxValue)
        //{
        //    string key = string.Format(SHIPPINGBYWEIGHT_ALL_KEY, pageIndex, pageSize);
        //    return await _cacheBase.GetAsync(key, () =>
        //    {
        //        var query = from sbw in _sbwRepository.Table
        //                    select sbw;

        //        return Task.FromResult(new PagedList<CPostShippingRecord>(query, pageIndex, pageSize));
        //    });
        //}

        //public virtual async Task<CPostShippingRecord> FindRecord(string shippingMethodId,
        //    string storeId, string warehouseId,
        //    string countryId, string stateProvinceId, string zip, double weight)
        //{
        //    if (zip == null)
        //        zip = string.Empty;
        //    zip = zip.Trim();

        //    var existingRates = (await GetAll())
        //        .Where(sbw => sbw.ShippingMethodId == shippingMethodId && weight >= sbw.From && weight <= sbw.To)
        //        .ToList();

        //    if (!string.IsNullOrEmpty(warehouseId))
        //        existingRates = existingRates.Where(x => x.WarehouseId == warehouseId).Any() 
        //            ? existingRates.Where(x => x.WarehouseId == warehouseId).ToList() 
        //            : existingRates.Where(x => string.IsNullOrEmpty(x.WarehouseId)).ToList();

        //    if (!string.IsNullOrEmpty(storeId))
        //        existingRates = existingRates.Where(x => x.StoreId == storeId).Any() 
        //            ? existingRates.Where(x => x.StoreId == storeId).ToList() 
        //            : existingRates.Where(x => string.IsNullOrEmpty(x.StoreId)).ToList();
            
        //    if (!string.IsNullOrEmpty(countryId))
        //        existingRates = existingRates.Where(x => x.CountryId == countryId).Any() 
        //            ? existingRates.Where(x => x.CountryId == countryId).ToList() 
        //            : existingRates.Where(x => string.IsNullOrEmpty(x.CountryId)).ToList();

        //    if (!string.IsNullOrEmpty(stateProvinceId))
        //        existingRates = existingRates.Where(x => x.StateProvinceId == stateProvinceId).Any() 
        //            ? existingRates.Where(x => x.StateProvinceId == stateProvinceId).ToList() 
        //            : existingRates.Where(x => string.IsNullOrEmpty(x.StateProvinceId)).ToList();

        //    if (!string.IsNullOrEmpty(zip))
        //        existingRates = existingRates.Where(x => x.Zip == zip).Any()
        //           ? existingRates.Where(x => x.Zip == zip).ToList()
        //           : existingRates.Where(x => string.IsNullOrEmpty(x.Zip)).ToList();

        //    return existingRates.FirstOrDefault();

        //}

        //public virtual Task<CPostShippingRecord> GetById(string shippingCPostRecordId)
        //{
        //    return _sbwRepository.GetByIdAsync(shippingCPostRecordId);
        //}

        //public virtual async Task InsertCPostShippingRecord(CPostShippingRecord shippingCPostRecord)
        //{
        //    if (shippingCPostRecord == null)
        //        throw new ArgumentNullException(nameof(shippingCPostRecord));

        //    await _sbwRepository.InsertAsync(shippingCPostRecord);

        //    await _cacheBase.RemoveByPrefix(SHIPPINGBYWEIGHT_PATTERN_KEY);
        //}

        //public virtual async Task UpdateCPostShippingRecord(CPostShippingRecord shippingCPostRecord)
        //{
        //    if (shippingCPostRecord == null)
        //        throw new ArgumentNullException(nameof(shippingCPostRecord));

        //    await _sbwRepository.UpdateAsync(shippingCPostRecord);

        //    await _cacheBase.RemoveByPrefix(SHIPPINGBYWEIGHT_PATTERN_KEY);
        //}

        //#endregion
    }

}
