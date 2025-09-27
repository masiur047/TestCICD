pipeline {
    agent any
    stages {
        stage('Checkout') {
            steps {
                checkout([$class: 'GitSCM',
                  branches: [[name: '*/main']],
                  userRemoteConfigs: [[url: 'https://github.com/masiur047/TestCICD.git']]
                ])
            }
        }
        stage('Build') {
            steps {
                echo "✅ Repo cloned successfully, starting build..."
                sh 'dotnet --version'
            }
        }
    }
}
