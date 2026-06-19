link video demo: https://mega.nz/file/MHZlBAhS#z8-yK5AeiT6uZPhQYzzvla-0g8UqTKrkj9zbC8Rh5q0

hướng dẫn:

trong powershell:

cd "(đường dẫn)\EventManagement_BCS242215"
dotnet restore
dotnet run --urls http://localhost:5088

nếu máy demo dùng SQL Server instance khác, chỉ cần đổi `Server=localhost` thành tên server/instance đang dùng.
khi chạy lần đầu, app tự tạo database và seed dữ liệu mẫu.

trong SQL Server Management Studio:

```sql
SELECT name FROM sys.databases WHERE name = 'MID_BCS242215';

USE MID_BCS242215;
SELECT TABLE_NAME
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_TYPE = 'BASE TABLE'
ORDER BY TABLE_NAME;

SELECT COUNT(*) AS TotalCategories FROM EventCategories_BCS242215;
SELECT COUNT(*) AS TotalEvents FROM Events_BCS242215;
SELECT COUNT(*) AS TotalImages FROM EventImages_BCS242215;
```

kết quả mong đợi:

- có database `MID_BCS242215`
- có 3 bảng `EventCategories_BCS242215`, `Events_BCS242215`, `EventImages_BCS242215`
- dữ liệu mẫu ban đầu: 3 loại sự kiện, 5 sự kiện, 5 ảnh
