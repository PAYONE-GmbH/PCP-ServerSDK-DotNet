#!/bin/sh

setup() {
    echo "Setting up the environment..."
    echo "Environment set up."
}

# Function to install dependencies
install() {
    echo "Installing dependencies..."
    echo "Dependencies installed."
}

# Function to build the package
build() {
    echo "Building the package..."
    dotnet build lib/PCPServerSDKDotNet/PCPServerSDKDotNet.csproj
    echo "Build complete."
}

# Function to run tests
test() {
    echo "Running tests..."
    dotnet test tests/PCPServerSDKDotNetTests --collect:"XPlat Code Coverage" -- DataCollectionRunSettings.DataCollectors.DataCollector.Configuration.Format=opencover
    echo "Tests complete."
}

lint() {
    echo "Running lint..."
    echo "Lint complete."
}

version() {
    # example: ./scripts.sh version 1.0.0
    if [ -z "$2" ]; then
        echo "Please provide the version."
        exit 1
    fi
    echo "Running version..."
    NEW_VERSION=$2
    CSPROJ_PATH="./lib/PCPServerSDKDotNet/PCPServerSDKDotNet.csproj"
    SERVER_META_INFO_PATH='./lib/PCPServerSDKDotNet/Utils/ServerMetaInfo.cs'
    SERVER_META_INFO_TEST_PATH='./tests/PCPServerSDKDotNetTests/Utils/ServerMetaInfo.cs'
    sed -i "" "s/<Version>.*<\/Version>/<Version>$NEW_VERSION<\/Version>/" ${CSPROJ_PATH}
    sed -i "" "s/<AssemblyVersion>.*<\/AssemblyVersion>/<AssemblyVersion>$NEW_VERSION.0<\/AssemblyVersion>/" ${CSPROJ_PATH}
    sed -i "" "s/<FileVersion>.*<\/FileVersion>/<FileVersion>$NEW_VERSION.0<\/FileVersion>/" ${CSPROJ_PATH}
    sed -i "" "s/<PackageVersion>.*<\/PackageVersion>/<PackageVersion>$NEW_VERSION<\/PackageVersion>/" ${CSPROJ_PATH}
    sed -i '' "s|DotNetServerSDK/v[0-9]*\.[0-9]*\.[0-9]*|DotNetServerSDK/v$NEW_VERSION|g" ${SERVER_META_INFO_PATH}
    sed -i '' "s|DotNetServerSDK/v[0-9]*\.[0-9]*\.[0-9]*|DotNetServerSDK/v$NEW_VERSION|g" ${SERVER_META_INFO_TEST_PATH}

    git add $CSPROJ_PATH
    git add $SERVER_META_INFO_PATH
    git add $SERVER_META_INFO_TEST_PATH
    npm install
    npm run changelog
    git add CHANGELOG.md
    # git tag -a v$NEW_VERSION -m "Version $NEW_VERSION"
    # git commit -m "Update version to $VERSION"
    # git push origin tag v$NEW_VERSION
    # git push origin HEAD

    echo "Version complete."
}

clear() {
    echo "Removing temp directories..."
    echo "All temp directories have been removed."
}

publish() {
    # example: ./scripts.sh publish <PyPI token>
    # check if the PyPI token is passed
    if [ -z "$2" ]; then
        echo "Please provide the PyPI token."
        exit 1
    fi
    echo "Uploading the package..."
    TOKEN=$2
    echo "Upload complete."
}

run() {
    echo "Running the package..."
    dotnet run --project app/PCPServerSDKDotNetRunner
}

# Check the first argument passed to the script
case "$1" in
setup)
    setup
    ;;
install)
    install
    ;;
build)
    build
    ;;
test)
    test
    ;;
lint)
    lint
    ;;
clear)
    clear
    ;;
version)
    version $@
    ;;
publish)
    publish $@
    ;;
run)
    run
    ;;
*)
    echo "Usage: $0 {setup|install|build|test|lint|clear|version|publish|run}"
    exit 1
    ;;
esac
