
pipeline {
    agent any

    stages {
        stage('Checkout Git') {
            steps {
                git branch: 'main',
                    url: 'https://github.com/YOUR-USERNAME/JenkinsGitPractice.git'
            }
        }

        stage('Check Files') {
            steps {
                echo 'GitHub source code downloaded successfully!'

                script {
                    if (isUnix()) {
                        sh 'ls -la'
                    } else {
                        bat 'dir'
                    }
                }
            }
        }
    }
}
