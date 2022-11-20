# Immagine da usare
FROM ghcr.io/ffxivita/docker-dalamud:latest@sha256:0c322e40954614ee0a326751490ac960c0ccd8884c0db79c84017e3465fb1165
    
# Variabili d'Ambiente
ENV DOTNET_CLI_TELEMETRY_OPTOUT=1
ENV DOTNET_SKIP_FIRST_TIME_EXPERIENCE=1
    
# Crea un utente non-root.
RUN adduser --disabled-password --gecos "" dev
# Installa le dipendenze.
RUN apk add --update openssh