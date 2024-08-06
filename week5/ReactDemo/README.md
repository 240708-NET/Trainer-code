# Patient Tracker

## Overview

This project is a comprehensive patient tracking system. It allows for the management of patients, doctors, procedures, and appointments through a set of RESTful APIs.

## APIs

### Create
- **Create a new doctor**
  - `POST /api/createDoctor/`
- **Create a new procedure**
  - `POST /api/createProcedure/`
- **Schedule a new procedure**
  - `POST /api/scheduleNewProcedure/`
- **Create a new patient**
  - `POST /api/createPatient/`

### Get
- **Get a doctor by ID**
  - `GET /api/Doctor/{id}`
- **Get a list of all doctors**
  - `GET /api/ListOfDoctors`
- **Get a patient by ID**
  - `GET /api/Patient/{id}`
- **Get a list of all patients**
  - `GET /api/ListOfPatients`
- **Get a list of all appointments**
  - `GET /api/ListofAppointments/`
- **Get an appointment by ID**
  - `GET /api/Appointment/{id}`
- **Get a procedure by ID**
  - `GET /api/Procedure/{id}`
- **Get a list of all procedures**
  - `GET /api/ListOfProcedures`

### Edit
- **Edit a doctor by ID**
  - `PUT /api/Doctor/{id}/edit`
- **Edit a patient by ID**
  - `PUT /api/Patient/{id}/edit`
- **Edit an appointment by ID**
  - `PUT /api/Appointment/{id}/edit`
- **Edit a procedure by ID**
  - `PUT /api/Procedure/{id}/edit`
- **Change user password by ID**
  - `PUT /api/user/{id}/changePsw`

### Delete
- **Delete a doctor by ID**
  - `DELETE /api/Doctor/{id}/delete`
- **Delete a patient by ID**
  - `DELETE /api/Patient/{id}/delete`
- **Delete an appointment by ID**
  - `DELETE /api/Appointment/{id}/delete`
- **Delete a procedure by ID**
  - `DELETE /api/Procedure/{id}/delete`
- **Delete a user by ID**
  - `DELETE /api/user/{id}/delete`

## Database and Tables

- **Patients**: Stores patient information.
- **Doctors**: Stores doctor information.
- **Procedures**: Stores procedure information.
- **Schedule**: Stores appointment schedules.
- **Users**: Stores user information.
- **Roles**: Stores role information.
