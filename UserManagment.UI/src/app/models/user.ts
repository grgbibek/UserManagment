export enum StatusEnum {
    Open = 1,
    Closed = 0
}

export interface User {
    id: number;
    name: string;
    username: string;
    age: number;
    phone: string;
    designation: string;
    status: StatusEnum;
}
