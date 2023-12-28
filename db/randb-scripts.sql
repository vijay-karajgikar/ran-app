use randb;

create table rides (
    ride_id bigint not null
        constraint fk_rides_ride_id_rider_appointments_ride_id
            foreign key (ride_id)
            references dbo.rider_appointments (ride_id),
    start_reading float not null,
    end_reading float not null,
    start_time datetime2 not null
        constraint df_rides_start_time default (getdate()),
    rider_pickup_time datetime2 not null
        constraint df_rides_rider_pickup_time default (getdate()),
    dest_dropoff_time datetime2 not null
        constraint df_rides_dropoff_time default (getdate()),
    dest_return_time datetime2 not null
        constraint df_rides_dest_return_time default (getdate()),
    rider_dropoff_time datetime2 not null
        constraint df_rides_rider_dropoff_time default (getdate()),
    created_date datetime2 not null
        constraint df_rides_created_date default (getdate()),
)

create table rider_appointments (
    ride_id bigint not null,
    ride_date datetime2 not null
        constraint df_rider_appointments_ride_date default (getdate()),
    rider_id bigint not null
        constraint fk_rider_appointments_rider_id_riders_rider_id
            foreign key (rider_id)
            references dbo.riders (rider_id),
    pickup_address_id bigint not null
        constraint fk_rider_appointments_rider_addresses_pickup_address_id
            foreign key (pickup_address_id)
            references dbo.rider_addresses (address_id),
    dropoff_address_id bigint not null
        constraint fk_rider_appointments_rider_addresses_dropoff_address_id
            foreign key (dropoff_address_id)
            references dbo.rider_addresses (address_id),
    rider_pickup_time datetime2 not null,
    rider_appt_time datetime2 not null,
    rider_ride_type int not null 
        constraint fk_rider_appointments_ride_types_rider_ride_type 
            foreign key (rider_ride_type)
            references dbo.ride_types (ride_type_id),
    ride_comments varchar(200),
    created_date datetime2 not null
        constraint df_rider_appointments_created_date default (getdate()),

    constraint pk_rider_appointments_ride_id primary key clustered (ride_id)
);

create table ride_types (
    ride_type_id int not null,
    ride_type_name varchar(10) not null,
    ride_type_description varchar(100),
    created_date datetime2 not null
        constraint df_ride_types_created_date default (getdate()),
    constraint pk_ride_types_ride_type_id primary key clustered (ride_type_id)
)

create table riders (
    rider_id bigint not null,
    rider_first_name varchar(50) not null,
    rider_last_name varchar(50) not null,
    rider_phone_no varchar(10) not null,
    rider_address_id bigint not null
        constraint fk_riders_rider_address_id_rider_addresses_address_id 
            foreign key (rider_address_id) 
            references dbo.rider_addresses (address_id),
    created_date datetime2 not null 
        constraint df_riders_created_date default (getdate()),
    constraint pk_riders_rider_id primary key clustered (rider_id)
        with (ignore_dup_key = off)
)

create table rider_addresses (
    address_id bigint not null,
    address_street varchar(100) not null,
    address_city varchar(50) not null,
    address_state varchar(50) not null,
    address_zip int not null,
    created_date datetime2 not null
        constraint df_rider_addresses_created_date default (getdate()),
    constraint pk_rider_addresses_address_id primary key clustered (address_id) with (ignore_dup_key = off) 
)