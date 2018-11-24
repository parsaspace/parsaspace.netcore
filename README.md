# Parsaspace.NET-Core
   Parsaspace .Net cross platform integration library
## Requirements
    ASP.NET Core 2  or later.
## Installation
  Install from [nuget](https://www.nuget.org/packages/parsaspace.netcore/)
  ### package manager
    Install-Package  parsaspace.netcore -Version 1.0.0
  ### .NET CLI
    dotnet add package parsaspace.netcore
	
## Get ListFile

```c#
          try 
            {
               parsaspace.netcore.v1 parsaspace = new parsaspace.netcore.v1("your token");
               var file = await  parsaspace.GetFileList("domain", "path");
               foreach (var item in file.List)
               {
                Console.WriteLine(item.Name);
               }
            }
            catch (parsaspace.netcore.Exceptions.ApiException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (parsaspace.netcore.Exceptions.ConnectionException ex)
            {
                Console.WriteLine(ex.Message);
            }  
```

## Upload File
```c#
          try 
            {
               parsaspace.netcore.v1 parsaspace = new parsaspace.netcore.v1("your token");
               var res = await  parsaspace.UploadFile("domain","uploadpath","filepath");
               if(res.Result=="true")
			   {
			    Console.WriteLine(res.DownloadLink);
			   }
            }
            catch (parsaspace.netcore.Exceptions.ApiException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (parsaspace.netcore.Exceptions.ConnectionException ex)
            {
                Console.WriteLine(ex.Message);
            }  
```




<div dir='rtl'>

## راه های ارتباطی

<a href="mailto:info@parsaspace.com" target="_top">info@parsaspace.com</a>

 26423760 021 

تهران ، خیابان میرداماد ، خیابان البرز ، تابان شرقی ، ملکی سودمند ، پلاک 2 ، واحد 10
</div>

<div dir='rtl'>
	
## راهنما

### معرفی API پارسااسپیس

پارسا اسپیس با داشتن REST API امکان ارتباط برنامه های مختلف را فراهم کرده است.در این سرویس شما می توانید به آسانی و امنیت بالا در هر نقطه ای از وب و در هر زمانی اطلاعات خود را ذخیره و بازیابی نمائید. هدف این سرویس، فراهم کردن امکانات آپلود، کپی، انتقال و غیره برای توسعه دهندگان است.

### ثبت نام رایگان با 5 گیگابایت فضای اختصاصی

با استفاده از این [لینک](https://parsaspace.com/register) میتوانید رایگان ثبت نام کنید و از 5 گیگابایت فضای اختصاصی بهره‌مند شوید.

### راهنمای برنامه نویسان

برای مشاهده مستندات API به صفحه [راهنمای برنامه نویسان](https://api.parsaspace.com/) مراجعه نمایید.


##
![https://parsaspace.com](https://cdn.parsaspace.com/parsaspace/new/img/logo.png)		

[https://parsaspace.com](https://parsaspace.com)	

</div>


            

  
