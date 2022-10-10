# RentaCarProject-Backend
# Backend with C#

Kurumsal, Katmanlı Mimari yapısı kullanılarak SOLID kuralları dahilinde oluşturulmuş, C# dili ile yazılmış Araba kiralama fikri üzerinden ilerlenmştir.

## Katmanlar

Core: Projenin çekirdek katmanı, evrensel operasyonlar için kullanılmaktadır.

Entities: Veritabanındaki tablolarımızın projemizde nesne olarak kullanılması için oluşturulmuştur. DTO nesnelerinide barındırmaktadır.

DataAccess: Projenin, Veritabanı ile bağını kuran katmandır.

Business: Projemizin iş katmanıdır. Türlü iş kuralları; Veri kontrolleri, validasyonlar, IoC Container'lar ve yetki kontrolleri

WebAPI: Prjenin Restful API Katmanıdır. Kullanılan methodlar: Get, Post, Put, Delete



## Kullanılan Teknolojiler

* Net Core 3.1
* Restful API
* Result Türleri
* Interceptor
* Autofac
* Fluent Validation
* Cache yönetimi
* JWT Authentication
* JWT Authentication
* Repository Design Pattern
* Cross Cutting Concerns
* Extensions


