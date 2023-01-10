# Immagine da usare
FROM ghcr.io/ffxivita/docker-dalamud:latest@sha256:63198caeedfa5be354c795987e4513f87deb53c5fd1ee2a6a3f3be1e7ab6cf68
    
# Variabili d'Ambiente
ENV DOTNET_CLI_TELEMETRY_OPTOUT=1
ENV DOTNET_SKIP_FIRST_TIME_EXPERIENCE=1
    
# Crea un utente non-root.
RUN adduser --disabled-password --gecos "" dev
# Installa le dipendenze.
RUN apk add --update openssh