# Шаблон dockerfile для aspnetcore приложения

Назначаем рабочую директорию, на ваше усмотрение:
```docker
WORKDIR /source/app
```

Копируем файлы исходного приложения в рабочую папку
```docker
COPY . . # 1) source_directory (aspapp) 2) destination directory (/source/app)
```

В текущей директории восстанавливаем ссылки на сторонние библиотеки 
```docker
RUN dotnet restore
```

```docker
RUN mkdir /source/publish
```
___
Открываю в контейнере порт с которым мы будет общаться с нашей основной машины и запускать с этого порта приложение
```docker
EXPOSE 80
```
Устанавливаем переменную окружения, отвечающую за URL на котором будет запускаться приложение в контейнере
```docker
ENV ASPNETCORE_URLS=http://+:80
```


