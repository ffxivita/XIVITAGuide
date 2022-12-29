# Immagine da usare
FROM ghcr.io/ffxivita/docker-dalamud:latest@sha256:ea3bc395211f1abc932d988c9c9be2729cd14e4b63b496525fbfd881a4031687
    
# Variabili d'Ambiente
ENV DOTNET_CLI_TELEMETRY_OPTOUT=1
ENV DOTNET_SKIP_FIRST_TIME_EXPERIENCE=1
    
# Crea un utente non-root.
RUN adduser --disabled-password --gecos "" dev
# Installa le dipendenze.
RUN apk add --update openssh