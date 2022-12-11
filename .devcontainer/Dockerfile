# Immagine da usare
FROM ghcr.io/ffxivita/docker-dalamud:latest@sha256:bd9aa6e362d4c92b005672e785905621fe96caa124942534af6c2c823963fe05
    
# Variabili d'Ambiente
ENV DOTNET_CLI_TELEMETRY_OPTOUT=1
ENV DOTNET_SKIP_FIRST_TIME_EXPERIENCE=1
    
# Crea un utente non-root.
RUN adduser --disabled-password --gecos "" dev
# Installa le dipendenze.
RUN apk add --update openssh