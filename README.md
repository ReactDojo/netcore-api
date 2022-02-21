Docker create image from repo
docker build -t image-name /path/to/repo
 
Kubernetes Cluster:
Control plane - coordinates the cluser
- Coodinates activites such as secheduling applications, managing state, scaling and updating

Nodes - Workers/servers than run the application
- Each node has a Kublet, which is an agent for managing the node and communicating with the control plane
- Each node *should* have a tool to handle container operations (Docker)

When you deploy applications, you tell the control plane to start the application containers
End users can also use the Kubernetes API directly to interact with the cluster

Deploy a cluster:
- minikube version
- minikube start //to start kubernetes cluser in VM
- kubectl version
- kubectl cluster-info //view cluster details
- kubectl get nodes //view available nodes in the cluster

Deploy containerized application
Kubectl uses the Kubernetes API to interact with the cluster
- kubectl version
- kubectl get nodes
- kubectl create deployment test-name --image=gcr.io/google-samples/kubernetes-bootcamp:v1
//when you create a deployment Kubernetes finds a node where an instance of the application could be run, scheduled the application to run on that node, configured the cluser to reshcdule the instance on a new node when needed
- kubectl get deployments
//kubectl interacts through an API endpoint to communicate with the application

Pods:
Kubernetes abstration that represents a group of one or more application containers
A pod can contain different application containers. Eg a client and server nodejs application
The containers in a pod share an IP address and port, and run in the same node
When we create a deployment, the deployment creates pods with containers inside them
In case of a node failure, identical pods are scheduled on other available nodes in the cluser
- kubectl get pods //get pod state
- kubectl describe pods //see inside pod: containers, and what images are used to build those containers
Pods are running in an isolated private network so we need to proxy access to them so we can interact with them
- kubectl proxy
- curl http://localhost:8001/api/v1/namespaces/default/pods/$POD_NAME/proxy/
- kubectl logs $POD_NAME
//execute commands directly on the container once the pod is running
- kubectl excel $POD_NAME
- kubectl exec -ti $POD_NAME -- bash //in bash, cat server.js
- curl localhost:8080 //to see application

Nodes:
A node is a worker machine and each worker node is managed by the control plane
A node can have multiple pods
The control place handles scheduling the pods across the nodes in the cluster
Each node must have at least:
1 Kubelet: Application responsible for communication between the control plane and the node; it managed running pods and the containers within its node
2. A container responsible for pulling the container image from a registry, unpacking and running the application

Service:
A service routes traffic across a set of Pods. Serivces are the abstraction that allow pods to die and replicate without impacting your application
Services match a set of pods using labels and selectors, labels are key/value pairs attached to objects used to designate, or classify the object
Abstration which defines a policy for a set of Pods by which to access them
Defined with YAML (or JSON)
Services expose a pod to outside traffic and allow your applications to receive traffic
ServerSpec Type (YAML): 
- ClusterIP(default) // exposes the service on an interal IP in the cluster
- NodePort // exposes the service on the same port of each selected node in the cluster using NAT. Makes a service accessible from otuside the cluster using NodeIP:NodePort
LoadBalancer // Create external load balancer in the current cloud and assigns fixed external IP to the service
ExternalName // Maps the service to the contents of the externalName field, by returning a CNAME record with it's value
- kubectl get services
- kubectl expose deployment/kubernetes-bootcamp --type="NodePort" --port 8080
- kubectl describe services/kubernetes-bootcamp
- kubectl delete service -l app=kubernetes-bootcamp

Labels:
- kubectl describe deployment
- kubectl get pods -l app=kubernetes-bootcamp // query list of pods
- kubectl get services -l app=kubernetes-bootcamp //query list of services

Scaling UP:
Scaling is accomplished by changing the number of replicas in a deployment
- kubectl get deployments
NAME // lists the names of deployments in the cluster
READY // ratio of CURRENT/DESIRED replicas
UP-TO-DATE // displays # of replicas that have been updated to the desired state
AVAILABLE // how many replicas of the application are available to your users
AGE // displays application time alive
- kubectl get rs // see the ReplicaSet // DEPLOYMENT-NAME - HASH
DESIRED // displays desired number of replicas in your application, (defined when you create the deployment)
CURRENT // currently running replicas
- kubectl scale deployments/kubernetes-bootcamp --replicas=4 //scale to 4 replicas
- kubectl get pods -o wide // 4 pods with different ip addresses

Scaling DOWN:
- kubectl scale deployments/kubernetes-bootcamp --replicas=2 // scale down to 2 replicas

Updating an application // ROLLING UPDATES
Rolling updates allow deployment updates to take place with zero downtime by incrmentally updating pods instances with new ones. The new pods will be scheduled on nodes with available resources
* You need multiple Pods for this to work without affecting application availability
If a deployment is exposed publicly, the service will load balance the traffic only to available pods during the update. 
- kubectl describe pods // to view all pods and current image version running on pod
- kubectl set image deployments/kubernetes-bootcamp kubernetes-bootcamp=jocatalin/kubernetes-bootcamp:v2 // update to v2
