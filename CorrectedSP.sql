USE [HOWeatherAppDB]
GO
/****** Object:  StoredProcedure [dbo].[spGetWeatherForecastsInAugust]    Script Date: 3/28/2024 8:16:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--2 spGetWeatherForecastsInAugust
ALTER PROCEDURE [dbo].[spGetWeatherForecastsInAugust]

@CID int
AS
BEGIN
SELECT *
FROM WeatherForecast
WHERE WFDate < '2023-09-01' and CID = @CID

END
