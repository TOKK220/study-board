import {Observable} from "rxjs";
import {map, mergeAll} from "rxjs/operators";
import {Injectable} from "@angular/core";
import {HttpClient} from "@angular/common/http";
import { ObjectUtility } from "@core/utility/object.utility";

@Injectable()
export abstract class BaseHttpService {

	constructor(protected http: HttpClient) {}

	castObject<T>(observable: Observable<any>, type: {new(): T}): Observable<T> {
		return observable.pipe(map(value => this.mapObjects([value], type)), mergeAll<T>());
	}
	castObjects<T>(observable: Observable<any>, type: {new(): T}): Observable<T[]> {
		return observable.pipe(map(value => this.mapObjects(value, type)));
	}
	mapObjects<T>(data: any[], type: {new(): T}): T[] {
		return  data.map<T>(dataItem => {
			let obj = new type();
			ObjectUtility.setObjectProperties(obj, dataItem);
			return obj;
		}, this);
	}
}