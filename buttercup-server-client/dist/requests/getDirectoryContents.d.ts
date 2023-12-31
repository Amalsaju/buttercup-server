import { FileItem, PathIdentifier } from "../types.js";
export interface InternalGetDirectoryContentsOptions {
    databaseURL: string;
    databaseUUID: string;
    pathIdentifier?: PathIdentifier;
}
export declare function getDirectoryContents(options: InternalGetDirectoryContentsOptions): Promise<Array<FileItem>>;
