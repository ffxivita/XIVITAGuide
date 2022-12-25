# Immagine da usare
FROM ghcr.io/ffxivita/docker-dalamud:latest@sha256:9d83578ef284d60bb9d75640742705b01662382317090bc6ca87020dc97aceaa
    
# Variabili d'Ambiente
ENV DOTNET_CLI_TELEMETRY_OPTOUT=1
ENV DOTNET_SKIP_FIRST_TIME_EXPERIENCE=1
    
# Crea un utente non-root.
RUN adduser --disabled-password --gecos "" dev
# Installa le dipendenze.
RUN apk add --update openssh