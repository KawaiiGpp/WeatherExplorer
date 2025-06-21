# WeatherExplorer - 天气查询
**WeatherExplorer** 是一个**简单的天气查询工具**，  
提供**中国各省、市、区县**的基础天气信息。  
**WeatherExplorer** is a **simple weather tool** that provides basic weather  
information for **provinces, cities and districts across China**.  
<br>

## 功能简介 - Features
- 通过选择的**省、市、区**定位到你想查找的位置。  
  Select the **province, city, and district** to locate your desired area.
- 点击**确认**按键，即可加载其天气信息。  
  Click **Confirm** to view its weather information.
- 天气信息包括了**气温、湿度、风和体感温度**。  
  Weather information includes **temperature, humidity, wind, and feels-like temperature**.
<br>

> 请注意：当前**仅支持查询国内**的天气信息。  
> Please note: Weather data is currently **available only for locations in China**.
<br>

## 如何使用 - Usage
本程序使用来自**APISpace**的**天气预报查询**功能，[也就是这里](https://www.apispace.com/eolink/api/456456/introduction)。  
The program uses the API from **APISpace**, [find out more there](https://www.apispace.com/eolink/api/456456/introduction).  
想要正常使用，你需要先配置**两个环境变量**。  
To run the program, make sure to set up **2 environment variables** first.  
- `WEATHER_API=[来自APISpace的URL，结尾保留now?areacode=即可]`  
  `WEATHER_API=[URL from APISpace ending with 'now?areacode=']`
- `WEATHER_TOKEN=[来自APISpace的你的Token]`  
  `WEATHER_TOKEN=[Your token from APISpace]`