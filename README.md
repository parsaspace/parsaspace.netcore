# Parsaspace.NET-Core

# <a href="https://api.parsaspace.com/">Parsaspace .NET Core RESTful API Document</a>
   Parsaspace .Net cross platform integration library
## Requirements
    ASP.NET Core 2  or later.
## Installation
<p>
First You need to make an account on Parsaspace from <a href="https://parsaspace.com/register">Here</a>
</p>
<p>
After that you just need to create website and  pick API-KEY up from <a href="https://parsaspace.com/profile">Profile</a> section.
Install from [nuget](https://www.nuget.org/packages/parsaspace.netcore/)
Use for every time.
</p>
  Install from [nuget](https://www.nuget.org/packages/parsaspace.netcore/)
  ### package manager
    Install-Package  parsaspace.netcore -Version 1.0.0
  ### .NET CLI
    dotnet add package parsaspace.netcore
    
## Get ListFile
لیست تمامی فایل ها و پوشه های مسیر مورد نظر کاربر را بر می گرداند.


```c#
          try 
            {
               parsaspace.netcore.v1 parsaspace = new parsaspace.netcore.v1("your token");
               var file = await  parsaspace.GetFileList("آدرس وب سایت شما", "/مسیر فایل های مورد نظر");
               foreach (var item in file.List)
               {
                Console.WriteLine(item.Name);
               }
            }
            catch (parsaspace.netcore.Exceptions.ApiException ex)
            {
			    // زمانی که مشکلی در اجرای سرویس فراخوانی شده وجود داشته باشد این خطا رخ می دهد 
                Console.WriteLine(ex.Message);
            }
            catch (parsaspace.netcore.Exceptions.ConnectionException ex)
            {
			    // زمانی که مشکلی در برقرای ارتباط با وب سرویس وجود داشته باشد این خطا رخ می دهد
                Console.WriteLine(ex.Message);
            }  
```


## Contribution
راه های ارتباطی 
<a href="mailto:info@parsaspace.com" target="_top">info@arsaspace.com</a>

021 26423760  

تهران ، خیابان میرداماد ، خیابان البرز ، تابان شرقی ، ملکی سودمند ، پلاک 2 ، واحد 10

<hr>

<div dir='rtl'>
	
## راهنما

### معرفی API پارسااسپیس

پارسا اسپیس با داشتن REST API امکان ارتباط برنامه های مختلف را فراهم کرده است.در این سرویس شما می توانید به آسانی و امنیت بالا در هر نقطه ای از وب و در هر زمانی اطلاعات خود را ذخیره و بازیابی نمائید. هدف این سرویس، فراهم کردن امکانات آپلود، کپی، انتقال و غیره برای توسعه دهندگان است. در این راهنما مفاهیم اصلی API Parsaspace و نحوه کار با آن توضیح داده شده است.

### ثبت نام رایگان با 5 گیگابایت فضای اختصاصی

با استفاده از این [لینک](https://parsaspace.com/register) میتوانید رایگان ثبت نام کنید و از 5 گیگابایت فضای اختصاصی بهره‌مند شوید.

### راهنمای برنامه نویسان

برای مشاهده مستندات API به صفحه [راهنمای برنامه نویسان](https://api.parsaspace.com/) مراجعه نمایید.


##
![https://parsaspace.com/](https://cdn.parsaspace.com/parsaspace/new/img/logo.png)		

[https://parsaspace.com/](https://parsaspace.com/)	

</div>


            

  
