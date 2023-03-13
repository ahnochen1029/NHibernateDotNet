# .net web api用NHibernate與Mysql進行CRUD資料庫操作
### VS CODE 開發

```
dotnet run
```

### Mysql環境
1. version 8.0.22
### Local mysql db
1. Database_name: nhibernate
2. table_name: Customer

### 從swagger ui call api

```
http://localhost:5192/swagger/index.html
```

### 連線設定檔
```
nhibernate.cfg.xml
```
NHibernateDotNet.csproj 檔案中需要增加EmbeddedResource

```xml
<EmbeddedResource Include="Models\Mapping\Customer.hbm.xml">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
</EmbeddedResource>
```

