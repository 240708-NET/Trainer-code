## ASP.NET Theory

### Service Oriented Architecture
Service-Oriented Architecture (SOA) is a design paradigm that structures software applications as a collection of loosely coupled, reusable, and interoperable services.

Useful links: 
- https://aws.amazon.com/what-is/service-oriented-architecture/
- https://www.bmc.com/blogs/service-oriented-architecture-overview/



**Key Points**
- **Services** - represents a piece of functionality that is self-contained and encapsulated. Basic building block;
- **Loose Coupling** -  independent of each other in terms of technology, platform, and implementation details.
- **Reusability** - reusable across different applications and scenarios



## Intro REST
REST (Representational State Transfer) is an architectural style for designing networked applications. 

RESTful systems are built around resources, which are accessed and manipulated using a set of predefined operations.

#### Constraints

- **Client-Server**: This constraint operates on the concept that the client and the server should be separate from each other and allowed to evolve individually.
- **Stateless**: REST APIs are stateless, meaning that calls can be made independently of one another, and each call contains all of the data necessary to complete itself successfully.
- **Cache**: Because a stateless API can increase request overhead by handling large loads of incoming and outbound calls, a REST API should be designed to encourage the storage of cacheable data.
- **Uniform Interface**: The key to the decoupling client from server is having a uniform interface that allows independent evolution of the application without having the application’s services, or models and actions, tightly coupled to the API layer itself.
- **Layered System**: REST APIs have different layers of their architecture working together to build a hierarchy that helps create a more scalable and modular application.
Code on Demand: Code on Demand allows for code or applets to be transmitted via the API for use within the application.

### How to use REST

Link to dummy Rest API:
https://www.dummy.restapiexample.com/

Designing RESTful APIs involves adhering to certain best practices to ensure consistency, usability, and scalability:
- **Resource naming conventions**: Use meaningful, plural nouns for resource URIs (e.g., /users, /products).
- **Proper use of HTTP methods**: Use HTTP methods correctly and idempotently. Idempotency ensures that multiple identical requests have the same effect as a single request.
- **Versioning and URI patterns**: Version APIs to manage changes and maintain backward compatibility (e.g., /v1/users).
- **Error handling and status codes**: Use appropriate HTTP status codes (2xx for success, 4xx for client errors, 5xx for server errors) and provide meaningful error messages in responses.

### HTTP
**Hypertext Transfer Protocol,** is the foundation of data communication for the World Wide Web. It is an application layer protocol used for transmitting hypermedia documents, such as HTML files, over the internet. 

**Key Characteristics of HTTP:**

- <p style="color:#FF5733; font-weight:bold">Client-Server Protocol</p>

    HTTP operates in a client-server model where a client makes requests for resources, and servers respond with those resources.

- <p style="color:#FF5733; font-weight:bold">Stateless Protocol:</p>

    HTTP is stateless, meaning each request from a client to a server is independent and unrelated to previous requests. The server does not retain any information about past requests from the same client.

- <p style="color:#FF5733; font-weight:bold">Connectionless Protocol:</p>

    HTTP is connectionless, meaning a connection between client and server is established only for the duration of each request. Once the server responds to a request, the connection is closed.

- <p style="color:#FF5733; font-weight:bold">Text-Based Protocol:</p>

    HTTP messages are human-readable text-based commands and responses exchanged between client and server. These messages are composed of headers and an optional body containing data.


### VERBS

Each HTTP method has specific semantics and is used in different scenarios to manipulate resources effectively. For example:
- **GET** is used to retrieve data without modifying it.
- **POST** is used to submit data for processing by a resource (e.g., creating a new user).
- **PUT** is used to update a resource's state or replace it entirely.
- **DELETE** is used to remove a resource from the server.
PATCH is used to apply partial modifications to a resource.

### Status Codes

HTTP status codes are grouped into five main classes:

**1xx - Informational Responses**

**2xx - Success:**
200OK, 201Created

**3xx - Redirection:**

301 Moved Permanently,

302 Found: 
The requested resource temporarily resides under a different URL.

**4xx - Client Errors:**

These codes indicate that there was a problem with the client's request. 
- **400 Bad Request**: The server could not understand the request due to invalid syntax.
- **401 Unauthorized**: The request requires user authentication.
- **404 Not Found**: The server could not find the requested resource.

- **5xx - Server Errors:**

    These codes indicate that the server encountered an error while trying to fulfill the request. 
- **500 Internal Server Error**


### Exposing and Consuming RestAPIs

Creating and exposing RESTful APIs involves designing endpoints that allow clients to interact with resources over HTTP.

- **Define Resources and URIs** (what entities/data you will expose: users,products, etc), create URI ( <span style="color:#FF5733;">/users, /products/{id}</span>)
- **Choose HTTP Methods** ((GET, POST, PUT, DELETE, PATCH, etc.)
- **Design Representations** (JSON, XML)
- **Implement Business Logic** (create controllers, handleers that handle incoing requests and generate responses)
- **Implement Error Handling** (Establish clear guidelines for error responses using appropriate HTTP status codes (e.g., 400 for client errors, 500 for server errors).)
- **Document Your API** (Use tools like Swagger/OpenAPI to automatically generate comprehensive documentation for your API.)
## HTTP Request Life Cycle

1. **DNS Resolution**:
   - The client initiates a request to a domain name (e.g., www.example.com).
   - The domain name is resolved to an IP address through DNS (Domain Name System) lookup.

2. **Connection Establishment**:
   - The client establishes a TCP (Transmission Control Protocol) connection with the server at the resolved IP address.
   - This involves a three-way handshake to set up the connection.

3. **HTTP Request**:
   - Once the connection is established, the client sends an HTTP request to the server.
   - The request consists of:
     - **Request Line**: Specifies the HTTP method (GET, POST, PUT, DELETE), the URI (Uniform Resource Identifier) of the resource, and the HTTP version.
     - **Headers**: Additional metadata sent with the request, including `Host`, `User-Agent`, `Content-Type`, `Accept`, etc.
     - **Body** (Optional): Data sent to the server, typically with methods like POST or PUT.

4. **Server Processing**:
   - The server receives the request and processes it according to the specified HTTP method and URI.
   - It performs any necessary operations, such as retrieving data from a database, processing business logic, or generating a response dynamically.

5. **HTTP Response**:
   - After processing the request, the server generates an HTTP response.
   - The response includes:
     - **Status Line**: Indicates the HTTP version, status code (e.g., 200 OK, 404 Not Found), and a reason phrase.
     - **Headers**: Additional metadata about the response, such as `Content-Type`, `Content-Length`, `Cache-Control`, etc.
     - **Body**: Optional data returned by the server, such as HTML content, JSON data, or binary data.

6. **Data Transfer**:
   - The server sends the HTTP response back to the client over the established TCP connection.
   - Data transfer occurs in the form of packets through the network infrastructure.

7. **Connection Termination**:
   - Once the response is fully transmitted, the server closes the TCP connection (unless kept alive for subsequent requests).
   - The client receives the entire response and processes the data as needed.

This cycle repeats for each HTTP request-response interaction between the client and the server. Understanding this life cycle helps in troubleshooting network issues, optimizing performance, and designing efficient web applications and APIs.


**RESTFUL API lifecycle by IBM:**
- API Requirement Definition
- API Modeling
- Generation of API Specifications and Code
-  Implementation and Management of the API

Link: https://www.postman.com/api-platform/api-lifecycle/

### Rest Resources and URL Construnction

**Resources** are the key abstractions in REST. They represent entities or concepts in the application domain, such as users, products, or orders. Each resource is uniquely identified by a URI.
Representations

**Representations** define how a resource is presented or accessed. Common representations include JSON (JavaScript Object Notation), XML (eXtensible Markup Language), and HTML (HyperText Markup Language). The choice of representation format depends on factors like client requirements and data complexity.
