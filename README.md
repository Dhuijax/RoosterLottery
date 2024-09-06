# RoosterLottery

Chạy trên Visual Studio 2022
- Giới thiệu
	Đây là một ứng dụng WinForms đơn giản được xây dựng bằng C# và .NET Framework/.Net Core.
	Ứng dụng này cung cấp các chức năng cơ bản để thực hiện việc mua vé số.

- Yêu cầu
	* .NET Framework: Ứng dụng yêu cầu .NET 8 (hoặc phiên bản tương thích khác).
	* Visual Studio: Để mở, chỉnh sửa và xây dựng ứng dụng, bạn cần Visual Studio 2022 hoặc phiên bản mới hơn.
	* Sql Server 2022 và SQL Server Management Studio Management Studio
- Cài đặt
		1. Clone Repository
			Đầu tiên, bạn cần phải clone repository từ GitHub (hoặc nơi lưu trữ mã nguồn) 
			về máy tính của bạn: git clone (https://github.com/username/repository-name.git)
		2. Mở Dự Án
			*Mở Visual Studio.
			*Chọn File > Open > Project/Solution.
			*Điều hướng đến thư mục chứa mã nguồn đã clone và mở tệp giải pháp (.sln).
		3. Cài Đặt Các Gói NuGet (nếu có)
			Nếu dự án sử dụng các gói NuGet, bạn có thể cài đặt chúng bằng cách mở 
			Package Manager Console từ Tools > NuGet Package Manager > Package Manager Console, 
			sau đó chạy: Update-Package -reinstall
		4. Thay thế 
				* connectionString: Project Server > appsettings.json
				* BackendUrl api: Project Client > App.config
		5. Restore file Lottery.bak vào Database.
- Xây Dựng Ứng Dụng
	Để xây dựng ứng dụng:
		1. Chọn cấu hình Build
			Trong Visual Studio, chọn cấu hình build từ dropdown ở góc trên bên phải (chẳng hạn: Debug hoặc Release).

		2. Xây Dựng Dự Án
			Chọn Build > Build Solution hoặc nhấn Ctrl + Shift + B.
			Visual Studio sẽ biên dịch mã nguồn và tạo ra các tệp thực thi (exe) trong thư mục bin của dự án.

- Chạy Ứng Dụng
	Sau khi xây dựng xong, bạn có thể chạy ứng dụng trực tiếp từ Visual Studio bằng cách nhấn F5 hoặc chọn Debug > Start Debugging.
	Nếu bạn muốn chạy ứng dụng từ bên ngoài Visual Studio, điều hướng đến thư mục bin\Debug hoặc bin\Release trong thư mục dự án của bạn và nhấp đúp vào tệp thực thi (.exe).

- Gỡ Rối
	Nếu bạn gặp lỗi khi xây dựng hoặc chạy ứng dụng, hãy kiểm tra các điều sau:
	* Đảm bảo tất cả các gói NuGet và phụ thuộc đã được cài đặt đúng.
	* Kiểm tra xem bạn có đang sử dụng phiên bản .NET Framework/.Net Core phù hợp không.
	* Xem lại thông báo lỗi trong Output Window hoặc Error List của Visual Studio.

- Tài Liệu Thêm
	Hướng dẫn WinForms (https://learn.microsoft.com/en-us/dotnet/desktop/winforms/?view=netdesktop-8.0&viewFallbackFrom=netdesktopdesktop-7.0)
	Tài liệu NuGet (https://learn.microsoft.com/en-us/nuget/)


Chạy trên bằng file exe.

- Cài đặt Sql Server 2022 và SQL Server Management Studio Management Studio
	Restore file Lottery.bak vào Database.
- Mở folder Server_Api:
	Thay đổi connectionString trong file appsettings.json
- Mở folder Winform_App:
	Thay đổi BackendUrl trong file Client.dll.config

Cấu trúc Source RoosterLottery
- Server
	📦Server
	 ┣ 📂bin
	 ┣ 📂Controllers
	 ┃ ┗ 📜StoreController.cs
	 ┣ 📂Models
	 ┃ ┗ 📜Store.cs
	 ┣ 📂obj
	 ┃ ┣ 📂Debug
	 ┃ ┣ 📜project.assets.json
	 ┃ ┣ 📜project.nuget.cache
	 ┃ ┣ 📜Server.csproj.nuget.dgspec.json
	 ┃ ┣ 📜Server.csproj.nuget.g.props
	 ┃ ┗ 📜Server.csproj.nuget.g.targets
	 ┣ 📂Properties
	 ┃ ┗ 📜launchSettings.json
	 ┣ 📂Utils
	 ┃ ┗ 📜DoStore.cs
	 ┣ 📜appsettings.Development.json
	 ┣ 📜appsettings.json
	 ┣ 📜Program.cs
	 ┣ 📜Server.csproj
	 ┣ 📜Server.csproj.user
	 ┗ 📜Server.http
- Client
📦Client
 ┣ 📂Apis
 ┃ ┣ 📜ServiceBet.cs
 ┃ ┗ 📜ServiceSlot.cs
 ┣ 📂bin
 ┃ ┗ 📂Debug
 ┃ ┃ ┗ 📂net8.0-windows
 ┃ ┃ ┃ ┣ 📜Client.deps.json
 ┃ ┃ ┃ ┣ 📜Client.dll
 ┃ ┃ ┃ ┣ 📜Client.dll.config
 ┃ ┃ ┃ ┣ 📜Client.exe
 ┃ ┃ ┃ ┣ 📜Client.pdb
 ┃ ┃ ┃ ┣ 📜Client.runtimeconfig.json
 ┃ ┃ ┃ ┗ 📜Newtonsoft.Json.dll
 ┣ 📂FromLs
 ┃ ┣ 📜Bet.cs
 ┃ ┣ 📜Bet.Designer.cs
 ┃ ┣ 📜Bet.resx
 ┃ ┣ 📜Home.cs
 ┃ ┣ 📜Home.Designer.cs
 ┃ ┣ 📜Home.resx
 ┃ ┣ 📜Homeless.cs
 ┃ ┣ 📜Homeless.Designer.cs
 ┃ ┣ 📜Homeless.resx
 ┃ ┣ 📜Login.cs
 ┃ ┣ 📜Login.Designer.cs
 ┃ ┣ 📜Login.resx
 ┃ ┣ 📜Register.cs
 ┃ ┣ 📜Register.Designer.cs
 ┃ ┗ 📜Register.resx
 ┣ 📂Models
 ┃ ┣ 📜Bet.cs
 ┃ ┣ 📜Parameter.cs
 ┃ ┣ 📜Slot.cs
 ┃ ┗ 📜User.cs
 ┣ 📂obj
 ┃ ┣ 📂Debug
 ┣ 📂Utils
 ┃ ┣ 📜ApiResponseItem.cs
 ┃ ┗ 📜Helper.cs
 ┣ 📜App.config
 ┣ 📜Client.csproj
 ┣ 📜Client.csproj.user
 ┗ 📜Program.cs