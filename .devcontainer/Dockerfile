# Immagine da usare
FROM ghcr.io/ffxivita/docker-dalamud:latest@sha256:35273491ae387da9d4a1066feacd33db58cb547d5efcfbf8504d4db5596e6f45
    
# Variabili d'Ambiente
ENV DOTNET_CLI_TELEMETRY_OPTOUT=1
ENV DOTNET_SKIP_FIRST_TIME_EXPERIENCE=1
    
# Crea un utente non-root.
RUN adduser --disabled-password --gecos "" dev
# Installa le dipendenze.
RUN apk add --update openssh